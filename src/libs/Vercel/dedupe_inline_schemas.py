"""Replace repeated large inline OpenAPI schemas with shared component references."""

import hashlib
import json
import sys
from collections import Counter
from pathlib import Path


MIN_SCHEMA_BYTES = 2_000
COMPONENT_PREFIX = "AutoSDKShared"


def is_schema(value):
    if not isinstance(value, dict):
        return False
    return (
        isinstance(value.get("type"), (str, list))
        or any(isinstance(value.get(key), list) for key in ("oneOf", "anyOf", "allOf"))
        or isinstance(value.get("properties"), dict)
        and not isinstance(value.get("type"), dict)
    )


def fingerprint(value):
    encoded = json.dumps(value, sort_keys=True, separators=(",", ":"))
    if len(encoded) < MIN_SCHEMA_BYTES:
        return None
    return hashlib.sha256(encoded.encode("utf-8")).hexdigest()


def dedupe(document):
    counts = Counter()
    originals = {}

    def count(value):
        if isinstance(value, dict):
            if is_schema(value) and (key := fingerprint(value)):
                counts[key] += 1
                originals.setdefault(key, value)
            for child in value.values():
                count(child)
        elif isinstance(value, list):
            for child in value:
                count(child)

    count(document)
    repeated = sorted(key for key, occurrences in counts.items() if occurrences > 1)
    names = {key: f"{COMPONENT_PREFIX}{key[:16]}" for key in repeated}
    if len(set(names.values())) != len(names):
        raise ValueError("Generated schema hash prefix collision")
    components = document.setdefault("components", {}).setdefault("schemas", {})
    collisions = set(names.values()) & set(components)
    if collisions:
        raise ValueError(f"Generated schema names collide with provider schemas: {sorted(collisions)}")

    def replace(value, defining=None):
        if isinstance(value, dict):
            if is_schema(value) and (key := fingerprint(value)) in names and key != defining:
                return {"$ref": f"#/components/schemas/{names[key]}"}
            return {name: replace(child, defining) for name, child in value.items()}
        if isinstance(value, list):
            return [replace(child, defining) for child in value]
        return value

    result = replace(document)
    for key in repeated:
        result["components"]["schemas"][names[key]] = replace(originals[key], defining=key)
    return result, len(repeated)


def main():
    path = Path(sys.argv[1])
    document = json.loads(path.read_text(encoding="utf-8"))
    result, count = dedupe(document)
    path.write_text(json.dumps(result, indent=2), encoding="utf-8")
    print(f"Shared {count} repeated inline OpenAPI schemas.")


if __name__ == "__main__":
    main()

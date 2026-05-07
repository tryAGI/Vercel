dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://openapi.vercel.sh/

# Fix CS9035: Remove required fields from inline oneOf schemas in update-invoice
# AutoSDK generates convenience overloads with empty objects that fail when fields are required
python3 -c "
import json, sys
with open('openapi.yaml', 'r') as f:
    spec = json.load(f)

path = '/v1/installations/{integrationConfigurationId}/billing/invoices/{invoiceId}/actions'
if path in spec.get('paths', {}):
    op = spec['paths'][path].get('post', {})
    body = op.get('requestBody', {}).get('content', {}).get('application/json', {}).get('schema', {})
    for item in body.get('oneOf', []):
        if 'required' in item:
            del item['required']

# The UserEvent payload is currently modeled as hundreds of inline oneOf variants.
# That produces a 300+ generic-argument union and enough generated source to make
# local Roslyn builds exit without diagnostics. Keep the field available, but
# expose the provider-specific payload as an untyped JSON object.
user_event = spec.get('components', {}).get('schemas', {}).get('UserEvent', {})
payload = user_event.get('properties', {}).get('payload')
if payload is not None:
    user_event['properties']['payload'] = {
        'type': 'object',
        'additionalProperties': True,
        'description': payload.get('description', 'The payload of the event, if requested.')
    }

# The project env contentHint payload repeats a 17-way inline oneOf across many
# response shapes. The generated names exceed ECMA-335 metadata limits once
# source generation is enabled, so keep the JSON payload untyped.
def collapse_content_hints(node):
    if isinstance(node, dict):
        properties = node.get('properties')
        if isinstance(properties, dict) and isinstance(properties.get('contentHint'), dict):
            description = properties['contentHint'].get('description', 'Provider-specific content hint metadata.')
            properties['contentHint'] = {
                'type': 'object',
                'nullable': True,
                'additionalProperties': True,
                'description': description
            }
        for value in node.values():
            collapse_content_hints(value)
    elif isinstance(node, list):
        for item in node:
            collapse_content_hints(item)

collapse_content_hints(spec)

with open('openapi.yaml', 'w') as f:
    json.dump(spec, f, indent=2)
"

autosdk generate openapi.yaml \
  --namespace Vercel \
  --clientClassName VercelClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# Vercel's schema is large enough that one monolithic STJ source-generation
# context makes Roslyn exit without diagnostics. Split the generated context into
# smaller source-generated contexts and expose a trim-safe delegating context.
python3 - <<'PY'
from pathlib import Path

base = Path("Generated")
context_path = base / "Vercel.JsonSerializerContext.g.cs"
context_types_path = base / "Vercel.JsonSerializerContextTypes.g.cs"
lines = context_path.read_text(encoding="utf-8").splitlines()

json_serializable_attributes = []
seen_attributes = set()
for line in lines:
    if "[global::System.Text.Json.Serialization.JsonSerializable" not in line:
        continue
    if "JsonSerializerContextTypes" in line:
        continue
    if line in seen_attributes:
        continue
    seen_attributes.add(line)
    json_serializable_attributes.append(line)

converter_types = []
seen_converters = set()
for line in lines:
    stripped = line.strip()
    if not stripped.startswith("typeof(") or "global::Vercel.JsonConverters." not in stripped:
        continue
    converter_type = stripped[len("typeof("):]
    if converter_type.endswith("),"):
        converter_type = converter_type[:-2]
    elif converter_type.endswith(")"):
        converter_type = converter_type[:-1]
    if converter_type in seen_converters:
        continue
    seen_converters.add(converter_type)
    converter_types.append(converter_type)

for path in base.glob("Vercel.JsonSerializerContext.Chunk*.g.cs"):
    path.unlink()

chunk_size = 500
chunks = [
    json_serializable_attributes[index:index + chunk_size]
    for index in range(0, len(json_serializable_attributes), chunk_size)
]

converter_attribute_lines = [
    "        Converters = new global::System.Type[]",
    "        {",
]
converter_attribute_lines.extend(f"            typeof({converter_type})," for converter_type in converter_types)
converter_attribute_lines.append("        })]")

common_prefix = "\n".join([
    "#nullable enable",
    "",
    "#pragma warning disable CS0618 // Type or member is obsolete",
    "#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant",
    "",
    "namespace Vercel",
    "{",
    "    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(",
    "        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,",
    "        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,",
    *converter_attribute_lines,
])

for index, chunk in enumerate(chunks):
    type_name = f"SourceGenerationContextChunk{index:03d}"
    chunk_path = base / f"Vercel.JsonSerializerContext.Chunk{index:03d}.g.cs"
    chunk_path.write_text(
        common_prefix
        + "\n"
        + "\n".join(chunk)
        + f"""
    internal sealed partial class {type_name} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
}}
""",
        encoding="utf-8")

resolver_initializers = ",\n".join(
    f"            new global::Vercel.SourceGenerationContextChunk{index:03d}(Options)"
    for index in range(len(chunks))
)

context_path.write_text(f"""#nullable enable

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Vercel;

/// <summary>
/// Source-generated serializer context used by generated Vercel clients.
/// </summary>
public sealed class SourceGenerationContext : JsonSerializerContext
{{
    private readonly IJsonTypeInfoResolver[] _resolvers;

    /// <summary>
    /// Default serializer context instance.
    /// </summary>
    public static SourceGenerationContext Default {{ get; }} = new();

    /// <summary>
    /// Creates a serializer context with the default generated options.
    /// </summary>
    public SourceGenerationContext()
        : this(CreateOptions())
    {{
    }}

    /// <summary>
    /// Creates a serializer context using the supplied options.
    /// </summary>
    public SourceGenerationContext(JsonSerializerOptions options)
        : base(options)
    {{
        _resolvers =
        [
{resolver_initializers}
        ];
    }}

    /// <inheritdoc />
    protected override JsonSerializerOptions? GeneratedSerializerOptions => Options;

    /// <inheritdoc />
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {{
        ArgumentNullException.ThrowIfNull(type);

        foreach (var resolver in _resolvers)
        {{
            var typeInfo = resolver.GetTypeInfo(type, Options);
            if (typeInfo is not null)
            {{
                return typeInfo;
            }}
        }}

        return null;
    }}

    private static JsonSerializerOptions CreateOptions()
    {{
        return new JsonSerializerOptions
        {{
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        }};
    }}
}}
""", encoding="utf-8")

context_types_path.unlink(missing_ok=True)
PY

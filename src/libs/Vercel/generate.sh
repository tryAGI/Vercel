install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://openapi.vercel.sh/

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

# Vercel repeats large inline schemas across operations. Reuse identical shapes
# so their models and STJ metadata are generated once.
python3 dedupe_inline_schemas.py openapi.yaml

autosdk generate openapi.yaml \
  --namespace Vercel \
  --clientClassName VercelClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

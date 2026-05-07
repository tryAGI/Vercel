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

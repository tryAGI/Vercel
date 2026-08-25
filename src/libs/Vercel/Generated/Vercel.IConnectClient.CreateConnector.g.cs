#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Create a connector<br/>
        /// Create a connector and optionally link it to a project. Use `type` with complete provider data, or use `service` with `connectionMethod` so Connect can supply the type, endpoints, templates, and defaults. Production project OIDC tokens may create OAuth connectors, plus credential-less API key connectors whose credentials are supplied per user. OIDC-created connectors are automatically linked within the deployment token's eligible project environments.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorResponse> CreateConnectorAsync(

            global::Vercel.ConnectCreateConnectorRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a connector<br/>
        /// Create a connector and optionally link it to a project. Use `type` with complete provider data, or use `service` with `connectionMethod` so Connect can supply the type, endpoints, templates, and defaults. Production project OIDC tokens may create OAuth connectors, plus credential-less API key connectors whose credentials are supplied per user. OIDC-created connectors are automatically linked within the deployment token's eligible project environments.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateConnectorResponse>> CreateConnectorAsResponseAsync(

            global::Vercel.ConnectCreateConnectorRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a connector<br/>
        /// Create a connector and optionally link it to a project. Use `type` with complete provider data, or use `service` with `connectionMethod` so Connect can supply the type, endpoints, templates, and defaults. Production project OIDC tokens may create OAuth connectors, plus credential-less API key connectors whose credentials are supplied per user. OIDC-created connectors are automatically linked within the deployment token's eligible project environments.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="data">
        /// Provider configuration. With type, provide the complete configuration for that type. With service and connectionMethod, provide only credentials and preferences; Connect supplies the type, endpoints, templates, and defaults. Other connector types accept an arbitrary object.
        /// </param>
        /// <param name="icon">
        /// SHA-1 digest of a PNG or JPEG icon that is at least 640 by 640 pixels. This field does not accept a URL or image bytes.<br/>
        /// First compute the digest and upload the raw image with [POST /v2/files](https://vercel.com/docs/rest-api/deployments/upload-deployment-files). Send `Content-Length` and the same 40-character digest in `x-vercel-digest`. Then set `icon` to that digest.<br/>
        /// ```js<br/>
        /// import { createHash } from 'node:crypto';<br/>
        /// import { readFile } from 'node:fs/promises';<br/>
        /// const VERCEL_TOKEN = process.env.VERCEL_TOKEN;<br/>
        /// const connectorId = 'scl_...';<br/>
        /// const bytes = await readFile('icon.png');<br/>
        /// const digest = createHash('sha1').update(bytes).digest('hex');<br/>
        /// await fetch('https://api.vercel.com/v2/files', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${VERCEL_TOKEN}`,<br/>
        ///     'Content-Type': 'application/octet-stream',<br/>
        ///     'Content-Length': String(bytes.length),<br/>
        ///     'x-vercel-digest': digest,<br/>
        ///   },<br/>
        ///   body: bytes,<br/>
        /// });<br/>
        /// await fetch(`https://api.vercel.com/v2/connect/connectors/${connectorId}`, {<br/>
        ///   method: 'PATCH',<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${VERCEL_TOKEN}`,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({ icon: digest }),<br/>
        /// });<br/>
        /// ```
        /// </param>
        /// <param name="backgroundColor">
        /// Branding background color (6-digit hex, for example
        /// </param>
        /// <param name="accentColor">
        /// Branding accent color (6-digit hex, for example
        /// </param>
        /// <param name="type">
        /// Connector implementation type for full configuration. Known types: api-key, discord, github, linear, linq, microsoft-entra, oauth, photon, salesforce, sendblue, slack, snowflake, snowflake-wif. Optional when service and connectionMethod select the type.
        /// </param>
        /// <param name="service">
        /// Service slug or URL for which the connector is used. Required when connectionMethod is set. Service alone does not enable preset configuration.
        /// </param>
        /// <param name="connectionMethod">
        /// Connection method slug of the service. Use it with service to select preset configuration.
        /// </param>
        /// <param name="params">
        /// Values for the selected connection method's template fields. Requires connectionMethod.
        /// </param>
        /// <param name="target">
        /// Which of the service's targets this connector is for. Requires \"connectionMethod\" and must be one that method serves. Optional.
        /// </param>
        /// <param name="uid">
        /// Optional team-scoped unique identifier for the connector. If omitted or empty, Connect generates a value.
        /// </param>
        /// <param name="name">
        /// Connector name. The value is trimmed and cannot contain control characters. If omitted or empty, the project name is used. A name or projectId is required. API key connectors require name.
        /// </param>
        /// <param name="projectId">
        /// Project to connect during creation. If environments is omitted, the connection uses development, preview, and production.
        /// </param>
        /// <param name="environments">
        /// Environments for the project connection. Requires projectId. Use one or more built-in environment names or stable custom environment IDs that belong to the project. Duplicate values are accepted and removed.
        /// </param>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="triggerDestination">
        /// Initial trigger destination. Requires triggers to be enabled and a projectId here or at the top level. Connector responses expose the resulting set as triggerDestinations. Replace the complete set with PATCH /v1/connect/connectors/{connector}/trigger-destinations.
        /// </param>
        /// <param name="events">
        /// Default trigger events for this connector.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorResponse> CreateConnectorAsync(
            global::Vercel.ConnectConnectorCreateData data,
            string? teamId = default,
            string? slug = default,
            string? icon = default,
            string? backgroundColor = default,
            string? accentColor = default,
            string? type = default,
            string? service = default,
            string? connectionMethod = default,
            global::System.Collections.Generic.Dictionary<string, string>? @params = default,
            string? target = default,
            string? uid = default,
            string? name = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>>? environments = default,
            bool? triggers = default,
            global::Vercel.OneOf<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>? triggerDestination = default,
            global::System.Collections.Generic.IList<string>? events = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
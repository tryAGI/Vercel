#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Update a connector<br/>
        /// Update a connector and return the connector with any service-side update signals that the caller must handle.
        /// </summary>
        /// <param name="connector">
        /// Stable connector ID or URL-encoded team-scoped UID. Examples: `scl_abc123` or `slack%2Fmy-bot`.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.ConnectConnectorUpdateResult> UpdateConnectorAsync(
            string connector,

            global::Vercel.ConnectUpdateConnectorRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connector<br/>
        /// Update a connector and return the connector with any service-side update signals that the caller must handle.
        /// </summary>
        /// <param name="connector">
        /// Stable connector ID or URL-encoded team-scoped UID. Examples: `scl_abc123` or `slack%2Fmy-bot`.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ConnectConnectorUpdateResult>> UpdateConnectorAsResponseAsync(
            string connector,

            global::Vercel.ConnectUpdateConnectorRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connector<br/>
        /// Update a connector and return the connector with any service-side update signals that the caller must handle.
        /// </summary>
        /// <param name="connector">
        /// Stable connector ID or URL-encoded team-scoped UID. Examples: `scl_abc123` or `slack%2Fmy-bot`.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="events">
        /// Default trigger events for this connector.
        /// </param>
        /// <param name="data">
        /// Provider configuration fields for the connector type.
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
        /// <param name="backgroundColor"></param>
        /// <param name="accentColor"></param>
        /// <param name="uid">
        /// Full team-scoped UID, such as `slack/my-bot`. It cannot contain whitespace, `%`, `#`, control characters, or Vercel-owned namespaces. Changing it breaks callers that use the old UID. The stable connector ID does not change.
        /// </param>
        /// <param name="name">
        /// Display name for the connector. It is trimmed and cannot be empty or contain control characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ConnectConnectorUpdateResult> UpdateConnectorAsync(
            string connector,
            string? teamId = default,
            string? slug = default,
            bool? triggers = default,
            global::System.Collections.Generic.IList<string>? events = default,
            global::Vercel.ConnectConnectorUpdateData? data = default,
            string? icon = default,
            string? backgroundColor = default,
            string? accentColor = default,
            string? uid = default,
            string? name = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
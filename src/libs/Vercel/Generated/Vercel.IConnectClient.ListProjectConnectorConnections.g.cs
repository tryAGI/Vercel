#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// List connectors for a project<br/>
        /// List the connectors connected to a project and the environments where each connection is available.
        /// </summary>
        /// <param name="projectId">
        /// Vercel project ID.
        /// </param>
        /// <param name="limit">
        /// Maximum number of connector connections to return. Defaults to 50.
        /// </param>
        /// <param name="cursor">
        /// Cursor from `pagination.next` on the previous response.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ConnectProjectConnectorConnectionList> ListProjectConnectorConnectionsAsync(
            string projectId,
            int? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List connectors for a project<br/>
        /// List the connectors connected to a project and the environments where each connection is available.
        /// </summary>
        /// <param name="projectId">
        /// Vercel project ID.
        /// </param>
        /// <param name="limit">
        /// Maximum number of connector connections to return. Defaults to 50.
        /// </param>
        /// <param name="cursor">
        /// Cursor from `pagination.next` on the previous response.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ConnectProjectConnectorConnectionList>> ListProjectConnectorConnectionsAsResponseAsync(
            string projectId,
            int? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
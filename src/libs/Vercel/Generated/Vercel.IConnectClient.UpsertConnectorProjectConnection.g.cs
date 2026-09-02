#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Create or update a connector project connection<br/>
        /// Connect a connector to a project, or replace the environments on an existing project connection.
        /// </summary>
        /// <param name="connector">
        /// Stable connector ID or URL-encoded team-scoped UID. Examples: `scl_abc123` or `slack%2Fmy-bot`.
        /// </param>
        /// <param name="projectId">
        /// Vercel project ID.
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
        global::System.Threading.Tasks.Task<global::Vercel.ConnectProjectConnection> UpsertConnectorProjectConnectionAsync(
            string connector,
            string projectId,

            global::Vercel.ConnectUpsertProjectConnectionRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a connector project connection<br/>
        /// Connect a connector to a project, or replace the environments on an existing project connection.
        /// </summary>
        /// <param name="connector">
        /// Stable connector ID or URL-encoded team-scoped UID. Examples: `scl_abc123` or `slack%2Fmy-bot`.
        /// </param>
        /// <param name="projectId">
        /// Vercel project ID.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ConnectProjectConnection>> UpsertConnectorProjectConnectionAsResponseAsync(
            string connector,
            string projectId,

            global::Vercel.ConnectUpsertProjectConnectionRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a connector project connection<br/>
        /// Connect a connector to a project, or replace the environments on an existing project connection.
        /// </summary>
        /// <param name="connector">
        /// Stable connector ID or URL-encoded team-scoped UID. Examples: `scl_abc123` or `slack%2Fmy-bot`.
        /// </param>
        /// <param name="projectId">
        /// Vercel project ID.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="environments">
        /// One or more built-in environment names or stable custom environment IDs that belong to the project. Duplicate values are accepted and removed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ConnectProjectConnection> UpsertConnectorProjectConnectionAsync(
            string connector,
            string projectId,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>> environments,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
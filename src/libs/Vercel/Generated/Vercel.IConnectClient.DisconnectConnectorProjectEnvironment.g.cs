#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Disconnect a connector from a project environment<br/>
        /// Remove a connector's access and event destinations for one project environment. Other environments, the connector, and its provider installations are preserved. Preview disconnect removes destinations for every preview branch in the project. Disconnecting the last environment also releases the project-local UID. Safe to retry.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="projectId"></param>
        /// <param name="environment">
        /// A built-in environment name or the stable env_* ID of a custom environment.
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DisconnectConnectorProjectEnvironmentAsync(
            string connector,
            string projectId,
            string environment,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disconnect a connector from a project environment<br/>
        /// Remove a connector's access and event destinations for one project environment. Other environments, the connector, and its provider installations are preserved. Preview disconnect removes destinations for every preview branch in the project. Disconnecting the last environment also releases the project-local UID. Safe to retry.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="projectId"></param>
        /// <param name="environment">
        /// A built-in environment name or the stable env_* ID of a custom environment.
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse> DisconnectConnectorProjectEnvironmentAsResponseAsync(
            string connector,
            string projectId,
            string environment,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Stop a session<br/>
        /// Stops a running session and releases its allocated resources. All running processes within the session will be terminated. This action cannot be undone. A stopped session cannot be restarted.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to stop.<br/>
        /// Example: sbx_abc123
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
        global::System.Threading.Tasks.Task<global::Vercel.StopSessionResponse> StopSessionAsync(
            string sessionId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
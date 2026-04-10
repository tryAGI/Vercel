#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Extend session timeout<br/>
        /// Extends the maximum execution time of a running session. The session must be active and able to accept commands. The total timeout cannot exceed the maximum allowed limit for your account.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to extend the timeout for.<br/>
        /// Example: sbx_abc123
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
        global::System.Threading.Tasks.Task<global::Vercel.ExtendSessionTimeoutResponse> ExtendSessionTimeoutAsync(
            string sessionId,

            global::Vercel.ExtendSessionTimeoutRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extend session timeout<br/>
        /// Extends the maximum execution time of a running session. The session must be active and able to accept commands. The total timeout cannot exceed the maximum allowed limit for your account.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to extend the timeout for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="duration">
        /// The amount of time in milliseconds to add to the current timeout. Must be at least 1000ms (1 second).<br/>
        /// Example: 300000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ExtendSessionTimeoutResponse> ExtendSessionTimeoutAsync(
            string sessionId,
            double duration,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Update network policy<br/>
        /// Replaces the network access policy of a running session. Use this to control which external hosts the session can communicate with. This is a full replacement. Any previously configured network rules will be overwritten.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to update the network policy for.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateSessionNetworkPolicyResponse> UpdateSessionNetworkPolicyAsync(
            string sessionId,

            global::Vercel.OneOf<global::Vercel.UpdateSessionNetworkPolicyRequestVariant1, global::Vercel.UpdateSessionNetworkPolicyRequestVariant2> request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update network policy<br/>
        /// Replaces the network access policy of a running session. Use this to control which external hosts the session can communicate with. This is a full replacement. Any previously configured network rules will be overwritten.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to update the network policy for.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UpdateSessionNetworkPolicyResponse>> UpdateSessionNetworkPolicyAsResponseAsync(
            string sessionId,

            global::Vercel.OneOf<global::Vercel.UpdateSessionNetworkPolicyRequestVariant1, global::Vercel.UpdateSessionNetworkPolicyRequestVariant2> request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update network policy<br/>
        /// Replaces the network access policy of a running session. Use this to control which external hosts the session can communicate with. This is a full replacement. Any previously configured network rules will be overwritten.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to update the network policy for.<br/>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateSessionNetworkPolicyResponse> UpdateSessionNetworkPolicyAsync(
            string sessionId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
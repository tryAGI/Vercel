#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to update the network policy for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyResponse> CreateSandboxesSessionsBySessionIdNetworkPolicyAsync(
            string sessionId,

            global::Vercel.OneOf<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1, global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2> request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to update the network policy for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyResponse>> CreateSandboxesSessionsBySessionIdNetworkPolicyAsResponseAsync(
            string sessionId,

            global::Vercel.OneOf<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1, global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2> request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to update the network policy for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyResponse> CreateSandboxesSessionsBySessionIdNetworkPolicyAsync(
            string sessionId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
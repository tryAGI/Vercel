#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to extend the timeout for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdExtendTimeoutResponse> CreateSandboxesSessionsBySessionIdExtendTimeoutAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdExtendTimeoutRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to extend the timeout for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateSandboxesSessionsBySessionIdExtendTimeoutResponse>> CreateSandboxesSessionsBySessionIdExtendTimeoutAsResponseAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdExtendTimeoutRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to extend the timeout for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="duration">
        /// The amount of time in milliseconds to add to the current timeout. Must be at least 1000ms (1 second).<br/>
        /// Example: 300000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdExtendTimeoutResponse> CreateSandboxesSessionsBySessionIdExtendTimeoutAsync(
            string sessionId,
            double duration,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
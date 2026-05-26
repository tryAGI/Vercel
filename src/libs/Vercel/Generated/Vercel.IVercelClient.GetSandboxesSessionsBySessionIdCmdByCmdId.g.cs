#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to retrieve.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="wait">
        /// If set to "true", the request will block until the command finishes execution. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdResponse> GetSandboxesSessionsBySessionIdCmdByCmdIdAsync(
            string sessionId,
            string cmdId,
            global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait? wait = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to retrieve.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="wait">
        /// If set to "true", the request will block until the command finishes execution. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdResponse>> GetSandboxesSessionsBySessionIdCmdByCmdIdAsResponseAsync(
            string sessionId,
            string cmdId,
            global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait? wait = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
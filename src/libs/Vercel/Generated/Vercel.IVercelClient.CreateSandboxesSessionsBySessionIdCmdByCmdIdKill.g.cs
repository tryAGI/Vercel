#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to terminate.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdCmdByCmdIdKillResponse> CreateSandboxesSessionsBySessionIdCmdByCmdIdKillAsync(
            string cmdId,
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdCmdByCmdIdKillRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to terminate.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateSandboxesSessionsBySessionIdCmdByCmdIdKillResponse>> CreateSandboxesSessionsBySessionIdCmdByCmdIdKillAsResponseAsync(
            string cmdId,
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdCmdByCmdIdKillRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to terminate.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="signal">
        /// The POSIX signal number to send to the process. Common values: 15 (SIGTERM) for graceful termination, 9 (SIGKILL) for forced termination.<br/>
        /// Example: 15
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdCmdByCmdIdKillResponse> CreateSandboxesSessionsBySessionIdCmdByCmdIdKillAsync(
            string cmdId,
            string sessionId,
            double signal,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
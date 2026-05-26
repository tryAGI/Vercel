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
        /// The unique identifier of the command to stream logs for.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vercel.OneOf<global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1, global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant2>> GetSandboxesSessionsBySessionIdCmdByCmdIdLogsAsync(
            string sessionId,
            string cmdId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
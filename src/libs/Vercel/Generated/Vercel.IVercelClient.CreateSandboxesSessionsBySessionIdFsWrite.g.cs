#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x_xCwd_">
        /// The target directory where the tarball contents will be extracted. If not specified, files are extracted to the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session to write files to.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateSandboxesSessionsBySessionIdFsWriteAsync(
            string sessionId,
            string? x_xCwd_ = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x_xCwd_">
        /// The target directory where the tarball contents will be extracted. If not specified, files are extracted to the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session to write files to.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> CreateSandboxesSessionsBySessionIdFsWriteAsResponseAsync(
            string sessionId,
            string? x_xCwd_ = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to read the file from.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSandboxesSessionsBySessionIdFsReadAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdFsReadRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to read the file from.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateSandboxesSessionsBySessionIdFsReadAsStreamAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdFsReadRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to read the file from.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<byte[]>> CreateSandboxesSessionsBySessionIdFsReadAsResponseAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdFsReadRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to read the file from.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cwd">
        /// The base directory for resolving relative paths. If not specified, paths are resolved from the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="path">
        /// The path of the file to read. Can be absolute or relative to the working directory.<br/>
        /// Example: dist/agent-output.md
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSandboxesSessionsBySessionIdFsReadAsync(
            string sessionId,
            string path,
            string? cwd = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
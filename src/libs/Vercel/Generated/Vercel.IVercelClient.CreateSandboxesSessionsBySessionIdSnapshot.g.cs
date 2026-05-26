#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to snapshot.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotResponse> CreateSandboxesSessionsBySessionIdSnapshotAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to snapshot.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotResponse>> CreateSandboxesSessionsBySessionIdSnapshotAsResponseAsync(
            string sessionId,

            global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to snapshot.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="expiration">
        /// The number of milliseconds after which the snapshot will expire and be deleted. Use 0 for no expiration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotResponse> CreateSandboxesSessionsBySessionIdSnapshotAsync(
            string sessionId,
            global::Vercel.OneOf<object, int?>? expiration = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
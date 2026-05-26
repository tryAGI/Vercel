#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to retrieve.<br/>
        /// Example: snap_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSandboxesSnapshotsBySnapshotIdResponse> GetSandboxesSnapshotsBySnapshotIdAsync(
            string snapshotId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to retrieve.<br/>
        /// Example: snap_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetSandboxesSnapshotsBySnapshotIdResponse>> GetSandboxesSnapshotsBySnapshotIdAsResponseAsync(
            string snapshotId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to delete.<br/>
        /// Example: snap_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteSandboxesSnapshotsBySnapshotIdResponse> DeleteSandboxesSnapshotsBySnapshotIdAsync(
            string snapshotId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to delete.<br/>
        /// Example: snap_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.DeleteSandboxesSnapshotsBySnapshotIdResponse>> DeleteSandboxesSnapshotsBySnapshotIdAsResponseAsync(
            string snapshotId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
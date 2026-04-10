#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get a snapshot<br/>
        /// Retrieves detailed information about a specific snapshot, including its creation time, size, expiration date, and the source sandbox it was created from.
        /// </summary>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to retrieve.<br/>
        /// Example: snap_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSnapshotResponse> GetSnapshotAsync(
            string snapshotId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
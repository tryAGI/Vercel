#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Delete a snapshot<br/>
        /// Permanently deletes a snapshot and frees its associated storage. This action cannot be undone. After deletion, the snapshot can no longer be used to create new sandboxes.
        /// </summary>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to delete.<br/>
        /// Example: snap_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteSnapshotResponse> DeleteSnapshotAsync(
            string snapshotId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
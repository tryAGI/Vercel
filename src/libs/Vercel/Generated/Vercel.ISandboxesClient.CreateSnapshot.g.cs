#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a snapshot<br/>
        /// Creates a point-in-time snapshot of a running sandbox's filesystem. Snapshots can be used to quickly restore a sandbox to a previous state or to create new sandboxes with pre-configured environments. The sandbox must be running and able to accept commands for a snapshot to be created. The sandbox will be terminated after the snapshot is created.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to snapshot.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSnapshotResponse> CreateSnapshotAsync(
            string sandboxId,

            global::Vercel.CreateSnapshotRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a snapshot<br/>
        /// Creates a point-in-time snapshot of a running sandbox's filesystem. Snapshots can be used to quickly restore a sandbox to a previous state or to create new sandboxes with pre-configured environments. The sandbox must be running and able to accept commands for a snapshot to be created. The sandbox will be terminated after the snapshot is created.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to snapshot.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="expiration">
        /// The number of milliseconds after which the snapshot will expire and be deleted. Use 0 for no expiration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSnapshotResponse> CreateSnapshotAsync(
            string sandboxId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.OneOf<object, int?>? expiration = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
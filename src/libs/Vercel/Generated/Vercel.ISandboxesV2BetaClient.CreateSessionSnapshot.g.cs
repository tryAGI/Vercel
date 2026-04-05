#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Create a snapshot<br/>
        /// Creates a point-in-time snapshot of a running session's filesystem. Snapshots can be used to quickly restore a session to a previous state or to create new sessions with pre-configured environments. The session must be running and able to accept commands for a snapshot to be created. The session will be terminated after the snapshot is created.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to snapshot.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSessionSnapshotResponse> CreateSessionSnapshotAsync(
            string sessionId,

            global::Vercel.CreateSessionSnapshotRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a snapshot<br/>
        /// Creates a point-in-time snapshot of a running session's filesystem. Snapshots can be used to quickly restore a session to a previous state or to create new sessions with pre-configured environments. The session must be running and able to accept commands for a snapshot to be created. The session will be terminated after the snapshot is created.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session to snapshot.<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSessionSnapshotResponse> CreateSessionSnapshotAsync(
            string sessionId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.OneOf<object, int?>? expiration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
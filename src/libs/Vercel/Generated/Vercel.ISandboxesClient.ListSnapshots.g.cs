#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List snapshots<br/>
        /// Retrieves a paginated list of snapshots for a specific project.
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list snapshots for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of snapshots to return in the response. Used for pagination.<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Filter snapshots created after this timestamp. Specified as Unix time in milliseconds.<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Filter snapshots created before this timestamp. Specified as Unix time in milliseconds.<br/>
        /// Example: 1540095775951L
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
        global::System.Threading.Tasks.Task<global::Vercel.ListSnapshotsResponse> ListSnapshotsAsync(
            string? project = default,
            double? limit = default,
            double? since = default,
            double? until = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
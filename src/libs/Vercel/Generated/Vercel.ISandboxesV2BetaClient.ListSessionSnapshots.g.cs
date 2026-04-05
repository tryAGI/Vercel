#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// List snapshots<br/>
        /// Retrieves a paginated list of snapshots for a specific project.
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list snapshots for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="name">
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="limit">
        /// Maximum number of snapshots to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for results by creation time.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.ListSessionSnapshotsResponseVariant2>> ListSessionSnapshotsAsync(
            string? project = default,
            string? name = default,
            double? limit = default,
            string? cursor = default,
            global::Vercel.ListSessionSnapshotsSortOrder? sortOrder = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
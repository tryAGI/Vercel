#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// List sandboxes<br/>
        /// Retrieves a paginated list of named sandboxes belonging to a specific project. Results can be sorted by creation time or name, and optionally filtered by name prefix.
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list named sandboxes for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of named sandboxes to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by.<br/>
        /// Default Value: createdAt
        /// </param>
        /// <param name="namePrefix">
        /// Filter named sandboxes whose name starts with this prefix. Only valid when sortBy=name.
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to desc.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="tags">
        /// Filter sandboxes by tag. Format: \"key:value\". Only one tag filter is supported at a time.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSandboxesV2Response> GetSandboxesV2Async(
            string? project = default,
            double? limit = default,
            global::Vercel.GetSandboxesV2SortBy? sortBy = default,
            string? namePrefix = default,
            string? cursor = default,
            global::Vercel.GetSandboxesV2SortOrder? sortOrder = default,
            global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List flag versions<br/>
        /// Lists flag versions for a given flag.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="flagIdOrSlug"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="environment">
        /// Environment to filter by
        /// </param>
        /// <param name="withMetadata">
        /// Whether to include metadata<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListFlagVersionsResponse> ListFlagVersionsAsync(
            string projectIdOrName,
            string flagIdOrSlug,
            double? limit = default,
            string? cursor = default,
            string? environment = default,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
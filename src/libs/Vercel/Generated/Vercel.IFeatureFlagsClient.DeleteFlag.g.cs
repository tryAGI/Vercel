#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Delete a flag<br/>
        /// Permanently delete a feature flag from the project. This action cannot be undone. Consider archiving the flag instead if you may need it in the future.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="flagIdOrSlug">
        /// The flag id or name
        /// </param>
        /// <param name="ifMatch">
        /// Etag to match, can be used interchangeably with the `if-match` header
        /// </param>
        /// <param name="withMetadata">
        /// Whether to include metadata in the response
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFlagAsync(
            string projectIdOrName,
            string flagIdOrSlug,
            string? ifMatch = default,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
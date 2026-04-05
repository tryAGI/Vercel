#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Delete a segment<br/>
        /// Delete a feature flag segment.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="segmentIdOrSlug">
        /// The segment slug
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
        global::System.Threading.Tasks.Task DeleteFlagSegmentAsync(
            string projectIdOrName,
            string segmentIdOrSlug,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
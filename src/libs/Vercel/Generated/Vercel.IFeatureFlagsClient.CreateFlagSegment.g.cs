#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Create a segment<br/>
        /// Create a new feature flag segment.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateFlagSegmentResponse> CreateFlagSegmentAsync(
            string projectIdOrName,

            global::Vercel.CreateFlagSegmentRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a segment<br/>
        /// Create a new feature flag segment.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestSlug"></param>
        /// <param name="createdBy">
        /// The entity who created the segment
        /// </param>
        /// <param name="label"></param>
        /// <param name="description"></param>
        /// <param name="data">
        /// The data of the segment
        /// </param>
        /// <param name="hint"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateFlagSegmentResponse> CreateFlagSegmentAsync(
            string projectIdOrName,
            string requestSlug,
            string label,
            global::Vercel.CreateFlagSegmentRequestData data,
            string hint,
            string? teamId = default,
            string? slug = default,
            string? createdBy = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
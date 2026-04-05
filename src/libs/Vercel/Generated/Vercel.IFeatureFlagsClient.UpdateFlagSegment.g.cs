#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Update a segment<br/>
        /// Update an existing feature flag segment.
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateFlagSegmentResponse2, global::Vercel.Segment>> UpdateFlagSegmentAsync(
            string projectIdOrName,
            string segmentIdOrSlug,

            global::Vercel.UpdateFlagSegmentRequest request,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a segment<br/>
        /// Update an existing feature flag segment.
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
        /// <param name="operations"></param>
        /// <param name="label"></param>
        /// <param name="description"></param>
        /// <param name="data">
        /// The data of the segment
        /// </param>
        /// <param name="hint"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateFlagSegmentResponse2, global::Vercel.Segment>> UpdateFlagSegmentAsync(
            string projectIdOrName,
            string segmentIdOrSlug,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestOperation>? operations = default,
            string? label = default,
            string? description = default,
            global::Vercel.UpdateFlagSegmentRequestData? data = default,
            string? hint = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
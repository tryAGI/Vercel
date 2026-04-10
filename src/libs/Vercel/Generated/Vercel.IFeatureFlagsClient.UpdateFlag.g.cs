#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Update a flag<br/>
        /// Update an existing feature flag. This endpoint supports partial updates, allowing you to modify specific properties like variants, environments, or state without providing the full flag configuration.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateFlagResponse2, global::Vercel.Flag>> UpdateFlagAsync(
            string projectIdOrName,
            string flagIdOrSlug,

            global::Vercel.UpdateFlagRequest request,
            string? ifMatch = default,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a flag<br/>
        /// Update an existing feature flag. This endpoint supports partial updates, allowing you to modify specific properties like variants, environments, or state without providing the full flag configuration.
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
        /// <param name="createdBy">
        /// The user who created this patch
        /// </param>
        /// <param name="message">
        /// Additional message for this version
        /// </param>
        /// <param name="variants">
        /// The variants of the flag
        /// </param>
        /// <param name="environments">
        /// The configuration for the flag in different environments
        /// </param>
        /// <param name="seed">
        /// A random seed to prevent split points in different flags from having the same targets
        /// </param>
        /// <param name="description">
        /// A description of the flag
        /// </param>
        /// <param name="state"></param>
        /// <param name="maintainerIds">
        /// The user ids of the maintainers of the flag
        /// </param>
        /// <param name="permanent">
        /// Whether this flag is marked as permanent, indicating it should not be removed
        /// </param>
        /// <param name="tags">
        /// Tags for categorizing the flag
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateFlagResponse2, global::Vercel.Flag>> UpdateFlagAsync(
            string projectIdOrName,
            string flagIdOrSlug,
            string? ifMatch = default,
            bool? withMetadata = default,
            string? teamId = default,
            string? slug = default,
            string? createdBy = default,
            string? message = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestVariant>? variants = default,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateFlagRequestEnvironments2>? environments = default,
            double? seed = default,
            string? description = default,
            global::Vercel.UpdateFlagRequestState? state = default,
            global::System.Collections.Generic.IList<string>? maintainerIds = default,
            bool? permanent = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
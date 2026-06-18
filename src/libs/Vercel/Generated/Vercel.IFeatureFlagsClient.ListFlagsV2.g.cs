#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List flags<br/>
        /// Retrieve feature flags for a project. Returns an opaque cursor for pagination.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="state">
        /// The state of the flags to retrieve. Defaults to `active`.
        /// </param>
        /// <param name="limit">
        /// Maximum number of flags to return.<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor to continue from.
        /// </param>
        /// <param name="search">
        /// Search flags by their slug or description. Case-insensitive.
        /// </param>
        /// <param name="tags">
        /// Filter flags by tag. Repeat the parameter for multiple tags (all must match).
        /// </param>
        /// <param name="createdBy">
        /// Filter flags by the id of the entity that created them (a user or team id).
        /// </param>
        /// <param name="maintainerIds">
        /// Filter flags by maintainer user id. Repeat the parameter for multiple maintainers (any may match).
        /// </param>
        /// <param name="includeMarketplaceFlags">
        /// Whether to include Marketplace experimentation items in the paginated response. Defaults to false.
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
        global::System.Threading.Tasks.Task<global::Vercel.ListFlagsV2Response> ListFlagsV2Async(
            string projectIdOrName,
            global::Vercel.ListFlagsV2State? state = default,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? createdBy = default,
            global::System.Collections.Generic.IList<string>? maintainerIds = default,
            bool? includeMarketplaceFlags = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List flags<br/>
        /// Retrieve feature flags for a project. Returns an opaque cursor for pagination.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="state">
        /// The state of the flags to retrieve. Defaults to `active`.
        /// </param>
        /// <param name="limit">
        /// Maximum number of flags to return.<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor to continue from.
        /// </param>
        /// <param name="search">
        /// Search flags by their slug or description. Case-insensitive.
        /// </param>
        /// <param name="tags">
        /// Filter flags by tag. Repeat the parameter for multiple tags (all must match).
        /// </param>
        /// <param name="createdBy">
        /// Filter flags by the id of the entity that created them (a user or team id).
        /// </param>
        /// <param name="maintainerIds">
        /// Filter flags by maintainer user id. Repeat the parameter for multiple maintainers (any may match).
        /// </param>
        /// <param name="includeMarketplaceFlags">
        /// Whether to include Marketplace experimentation items in the paginated response. Defaults to false.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListFlagsV2Response>> ListFlagsV2AsResponseAsync(
            string projectIdOrName,
            global::Vercel.ListFlagsV2State? state = default,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? createdBy = default,
            global::System.Collections.Generic.IList<string>? maintainerIds = default,
            bool? includeMarketplaceFlags = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
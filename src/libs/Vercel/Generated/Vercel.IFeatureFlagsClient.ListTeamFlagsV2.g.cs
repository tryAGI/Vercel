#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List all flags for a team<br/>
        /// Retrieve all feature flags for a team across all projects. Returns an opaque cursor for pagination.
        /// </summary>
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
        /// <param name="kind">
        /// The kind of flags to retrieve.
        /// </param>
        /// <param name="tags">
        /// Filter flags by tag. Repeat the parameter for multiple tags (all must match).
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
        global::System.Threading.Tasks.Task<global::Vercel.ListTeamFlagsV2Response> ListTeamFlagsV2Async(
            string teamId,
            global::Vercel.ListTeamFlagsV2State? state = default,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            global::Vercel.ListTeamFlagsV2Kind? kind = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? includeMarketplaceFlags = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all flags for a team<br/>
        /// Retrieve all feature flags for a team across all projects. Returns an opaque cursor for pagination.
        /// </summary>
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
        /// <param name="kind">
        /// The kind of flags to retrieve.
        /// </param>
        /// <param name="tags">
        /// Filter flags by tag. Repeat the parameter for multiple tags (all must match).
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListTeamFlagsV2Response>> ListTeamFlagsV2AsResponseAsync(
            string teamId,
            global::Vercel.ListTeamFlagsV2State? state = default,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            global::Vercel.ListTeamFlagsV2Kind? kind = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? includeMarketplaceFlags = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
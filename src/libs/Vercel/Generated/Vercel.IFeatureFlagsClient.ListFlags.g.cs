#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List flags<br/>
        /// Retrieve feature flags for a project. The list can be filtered by state and supports pagination.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="state">
        /// The state of the flags to retrieve. Defaults to `active`.
        /// </param>
        /// <param name="withMetadata">
        /// Whether to include metadata in the response
        /// </param>
        /// <param name="limit">
        /// Maximum number of flags to return. When not set, all flags are returned.
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
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListFlagsResponse> ListFlagsAsync(
            string projectIdOrName,
            global::Vercel.ListFlagsState? state = default,
            bool? withMetadata = default,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
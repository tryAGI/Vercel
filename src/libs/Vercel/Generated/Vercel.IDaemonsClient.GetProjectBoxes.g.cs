#nullable enable

namespace Vercel
{
    public partial interface IDaemonsClient
    {
        /// <summary>
        /// Get project daemons<br/>
        /// Lists project daemons.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="limit">
        /// Maximum daemons to return (default: 10, max: 100)
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="scopeType">
        /// Filter by scope type
        /// </param>
        /// <param name="scopeValue">
        /// Filter by scope value (requires scopeType)
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
        global::System.Threading.Tasks.Task<global::Vercel.GetProjectBoxesResponse> GetProjectBoxesAsync(
            string idOrName,
            string? limit = default,
            string? cursor = default,
            global::Vercel.GetProjectBoxesScopeType? scopeType = default,
            string? scopeValue = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get project daemons<br/>
        /// Lists project daemons.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="limit">
        /// Maximum daemons to return (default: 10, max: 100)
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="scopeType">
        /// Filter by scope type
        /// </param>
        /// <param name="scopeValue">
        /// Filter by scope value (requires scopeType)
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetProjectBoxesResponse>> GetProjectBoxesAsResponseAsync(
            string idOrName,
            string? limit = default,
            string? cursor = default,
            global::Vercel.GetProjectBoxesScopeType? scopeType = default,
            string? scopeValue = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
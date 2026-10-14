#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// List rules<br/>
        /// List the authenticated team's routing rules, oldest first. Without `limit` or `cursor`, returns every rule. With either, returns one page and a `nextCursor` for the next page (null on the last page). Paging reads and sorts the team's rules server-side, which is fine at current rule counts.
        /// </summary>
        /// <param name="includeDisabled"></param>
        /// <param name="limit">
        /// Maximum number of rules to return (capped at 200). Enables pagination.
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor returned by a prior call as nextCursor.
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayRuleList> ListAiGatewayRulesAsync(
            global::Vercel.ListAiGatewayRulesIncludeDisabled? includeDisabled = default,
            int? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List rules<br/>
        /// List the authenticated team's routing rules, oldest first. Without `limit` or `cursor`, returns every rule. With either, returns one page and a `nextCursor` for the next page (null on the last page). Paging reads and sorts the team's rules server-side, which is fine at current rule counts.
        /// </summary>
        /// <param name="includeDisabled"></param>
        /// <param name="limit">
        /// Maximum number of rules to return (capped at 200). Enables pagination.
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor returned by a prior call as nextCursor.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayRuleList>> ListAiGatewayRulesAsResponseAsync(
            global::Vercel.ListAiGatewayRulesIncludeDisabled? includeDisabled = default,
            int? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
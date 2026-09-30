#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// List AI Gateway budgets<br/>
        /// List the team's AI Gateway budgets (team/project/user scopes, plus default-covered api-key spend) as a flat list, optionally filtered by scope.
        /// </summary>
        /// <param name="scopeType">
        /// Restrict the list to a single budget scope.
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudgetList> ListAiGatewayBudgetsAsync(
            global::Vercel.ListAiGatewayBudgetsScopeType? scopeType = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List AI Gateway budgets<br/>
        /// List the team's AI Gateway budgets (team/project/user scopes, plus default-covered api-key spend) as a flat list, optionally filtered by scope.
        /// </summary>
        /// <param name="scopeType">
        /// Restrict the list to a single budget scope.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayBudgetList>> ListAiGatewayBudgetsAsResponseAsync(
            global::Vercel.ListAiGatewayBudgetsScopeType? scopeType = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
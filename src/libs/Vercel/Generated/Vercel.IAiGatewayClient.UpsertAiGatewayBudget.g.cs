#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Upsert AI Gateway budget<br/>
        /// Create or update a team-, project-, user-, or app-scope AI Gateway budget. Set a total with `limitAmount`, or raise the current budget with `increaseBy`.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudget> UpsertAiGatewayBudgetAsync(

            global::Vercel.UpsertAiGatewayBudgetRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert AI Gateway budget<br/>
        /// Create or update a team-, project-, user-, or app-scope AI Gateway budget. Set a total with `limitAmount`, or raise the current budget with `increaseBy`.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayBudget>> UpsertAiGatewayBudgetAsResponseAsync(

            global::Vercel.UpsertAiGatewayBudgetRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert AI Gateway budget<br/>
        /// Create or update a team-, project-, user-, or app-scope AI Gateway budget. Set a total with `limitAmount`, or raise the current budget with `increaseBy`.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="scopeType"></param>
        /// <param name="projectId">
        /// Required when scopeType is \"project\".
        /// </param>
        /// <param name="userId">
        /// Required when scopeType is \"user\".
        /// </param>
        /// <param name="appId">
        /// Required when scopeType is \"app\". The id of a Vercel App (`cl_…`).
        /// </param>
        /// <param name="limitAmount">
        /// Budget limit in dollars. Provide this or `increaseBy`, not both.
        /// </param>
        /// <param name="increaseBy">
        /// Dollars to add to the current budget, or to the scope's default when it has no budget of its own. Provide this or `limitAmount`, not both. Keeps the current refresh period and BYOK setting unless they are given.
        /// </param>
        /// <param name="refreshPeriod">
        /// Defaults to monthly with `limitAmount`; `increaseBy` keeps the current period.
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether BYOK usage counts toward this budget.
        /// </param>
        /// <param name="alertThresholds"></param>
        /// <param name="justification">
        /// Why the budget is being changed, up to 500 characters. Recorded in the activity log and audit log drains, and sent in the ai-gateway.budget.updated webhook.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudget> UpsertAiGatewayBudgetAsync(
            global::Vercel.UpsertAiGatewayBudgetRequestScopeType scopeType,
            string? teamId = default,
            string? slug = default,
            string? projectId = default,
            string? userId = default,
            string? appId = default,
            double? limitAmount = default,
            double? increaseBy = default,
            global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod? refreshPeriod = default,
            bool? includeByokInQuota = default,
            global::System.Collections.Generic.IList<double>? alertThresholds = default,
            string? justification = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
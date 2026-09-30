#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Upsert AI Gateway budget<br/>
        /// Create or update a team-, project-, or user-scope AI Gateway budget.
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
        /// Create or update a team-, project-, or user-scope AI Gateway budget.
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
        /// Create or update a team-, project-, or user-scope AI Gateway budget.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="scopeType"></param>
        /// <param name="projectId">
        /// Required when scopeType is "project".
        /// </param>
        /// <param name="userId">
        /// Required when scopeType is "user".
        /// </param>
        /// <param name="limitAmount">
        /// Budget limit in dollars.
        /// </param>
        /// <param name="refreshPeriod">
        /// Default Value: monthly
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether BYOK usage counts toward this budget.
        /// </param>
        /// <param name="alertThresholds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudget> UpsertAiGatewayBudgetAsync(
            global::Vercel.UpsertAiGatewayBudgetRequestScopeType scopeType,
            double limitAmount,
            string? teamId = default,
            string? slug = default,
            string? projectId = default,
            string? userId = default,
            global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod? refreshPeriod = default,
            bool? includeByokInQuota = default,
            global::System.Collections.Generic.IList<double>? alertThresholds = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
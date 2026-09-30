#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Upsert AI Gateway budget default<br/>
        /// Create or update an AI Gateway budget default for one scope. Team-level authority only (owners/admins).
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudgetDefault> UpsertAiGatewayBudgetDefaultAsync(

            global::Vercel.UpsertAiGatewayBudgetDefaultRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert AI Gateway budget default<br/>
        /// Create or update an AI Gateway budget default for one scope. Team-level authority only (owners/admins).
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayBudgetDefault>> UpsertAiGatewayBudgetDefaultAsResponseAsync(

            global::Vercel.UpsertAiGatewayBudgetDefaultRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert AI Gateway budget default<br/>
        /// Create or update an AI Gateway budget default for one scope. Team-level authority only (owners/admins).
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="scopeType"></param>
        /// <param name="limitAmount">
        /// Default budget limit in dollars.
        /// </param>
        /// <param name="refreshPeriod"></param>
        /// <param name="alertThresholds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudgetDefault> UpsertAiGatewayBudgetDefaultAsync(
            global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType scopeType,
            double limitAmount,
            string? teamId = default,
            string? slug = default,
            global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod? refreshPeriod = default,
            global::System.Collections.Generic.IList<double>? alertThresholds = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Archive AI Gateway budget<br/>
        /// Archive a team-, project-, or user-scope AI Gateway budget.
        /// </summary>
        /// <param name="scopeType">
        /// The budget scope to archive.
        /// </param>
        /// <param name="projectId">
        /// Required when scopeType is "project".
        /// </param>
        /// <param name="userId">
        /// Required when scopeType is "user".
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayBudget> ArchiveAiGatewayBudgetAsync(
            global::Vercel.ArchiveAiGatewayBudgetScopeType scopeType,
            string? projectId = default,
            string? userId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive AI Gateway budget<br/>
        /// Archive a team-, project-, or user-scope AI Gateway budget.
        /// </summary>
        /// <param name="scopeType">
        /// The budget scope to archive.
        /// </param>
        /// <param name="projectId">
        /// Required when scopeType is "project".
        /// </param>
        /// <param name="userId">
        /// Required when scopeType is "user".
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayBudget>> ArchiveAiGatewayBudgetAsResponseAsync(
            global::Vercel.ArchiveAiGatewayBudgetScopeType scopeType,
            string? projectId = default,
            string? userId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
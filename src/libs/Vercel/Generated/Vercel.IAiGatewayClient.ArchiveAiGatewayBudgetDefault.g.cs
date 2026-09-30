#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Archive AI Gateway budget default<br/>
        /// Delete an AI Gateway budget default for one scope. Team-level authority only (owners/admins).
        /// </summary>
        /// <param name="scopeType">
        /// The budget default scope to delete.
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
        global::System.Threading.Tasks.Task ArchiveAiGatewayBudgetDefaultAsync(
            global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType scopeType,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive AI Gateway budget default<br/>
        /// Delete an AI Gateway budget default for one scope. Team-level authority only (owners/admins).
        /// </summary>
        /// <param name="scopeType">
        /// The budget default scope to delete.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse> ArchiveAiGatewayBudgetDefaultAsResponseAsync(
            global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType scopeType,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
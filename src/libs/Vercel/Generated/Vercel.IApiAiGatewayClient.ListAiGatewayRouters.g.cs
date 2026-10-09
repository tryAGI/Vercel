#nullable enable

namespace Vercel
{
    public partial interface IApiAiGatewayClient
    {
        /// <summary>
        /// List AI Gateway routers<br/>
        /// List the authenticated team's active and archived custom routers.
        /// </summary>
        /// <param name="ownerId">
        /// The owner (team) ID to list routers for. Only trusted-origin callers use this. Public callers select their team with `teamId` or `slug`, and a supplied ownerId never overrides the authenticated team.
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayRouterList> ListAiGatewayRoutersAsync(
            string? ownerId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List AI Gateway routers<br/>
        /// List the authenticated team's active and archived custom routers.
        /// </summary>
        /// <param name="ownerId">
        /// The owner (team) ID to list routers for. Only trusted-origin callers use this. Public callers select their team with `teamId` or `slug`, and a supplied ownerId never overrides the authenticated team.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayRouterList>> ListAiGatewayRoutersAsResponseAsync(
            string? ownerId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
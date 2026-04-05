#nullable enable

namespace Vercel
{
    public partial interface IProjectRoutesClient
    {
        /// <summary>
        /// Generate a routing rule from natural language<br/>
        /// Generate a routing rule configuration from a natural language description. Returns a suggested route configuration that can be reviewed and saved.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GenerateRouteResponse> GenerateRouteAsync(
            string projectId,

            global::Vercel.GenerateRouteRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a routing rule from natural language<br/>
        /// Generate a routing rule configuration from a natural language description. Returns a suggested route configuration that can be reviewed and saved.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="currentRoute"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GenerateRouteResponse> GenerateRouteAsync(
            string projectId,
            string prompt,
            string? teamId = default,
            string? slug = default,
            global::Vercel.GenerateRouteRequestCurrentRoute? currentRoute = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
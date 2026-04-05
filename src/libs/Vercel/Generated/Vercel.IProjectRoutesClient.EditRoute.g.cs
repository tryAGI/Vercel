#nullable enable

namespace Vercel
{
    public partial interface IProjectRoutesClient
    {
        /// <summary>
        /// Edit a routing rule<br/>
        /// Replace a routing rule identified by its ID, or restore it from the current production version. Stages a new version with the modified route.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="routeId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.EditRouteResponse> EditRouteAsync(
            string projectId,
            string routeId,

            global::Vercel.EditRouteRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a routing rule<br/>
        /// Replace a routing rule identified by its ID, or restore it from the current production version. Stages a new version with the modified route.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="routeId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="route">
        /// The full route object to replace the existing route with
        /// </param>
        /// <param name="restore">
        /// If true, restores the staged route to the value in the production version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.EditRouteResponse> EditRouteAsync(
            string projectId,
            string routeId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.EditRouteRequestRoute? route = default,
            bool? restore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
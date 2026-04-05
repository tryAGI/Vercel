#nullable enable

namespace Vercel
{
    public partial interface IProjectRoutesClient
    {
        /// <summary>
        /// Promote, restore, or discard a routing rule version<br/>
        /// Promote staged routing rules to production, restore a previous production version, or discard staged changes. - `promote`: Publishes the staging version to production. - `restore`: Rolls back to a previous production version. - `discard`: Removes the staging version without publishing.
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateRouteVersionsResponse> UpdateRouteVersionsAsync(
            string projectId,

            global::Vercel.UpdateRouteVersionsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote, restore, or discard a routing rule version<br/>
        /// Promote staged routing rules to production, restore a previous production version, or discard staged changes. - `promote`: Publishes the staging version to production. - `restore`: Rolls back to a previous production version. - `discard`: Removes the staging version without publishing.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="id"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateRouteVersionsResponse> UpdateRouteVersionsAsync(
            string projectId,
            string id,
            global::Vercel.UpdateRouteVersionsRequestAction action,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IProjectRoutesClient
    {
        /// <summary>
        /// Get project routing rules<br/>
        /// Get the routing rules for a project. Supports searching by name/ID/pattern, filtering by route type, and diffing staged changes against production.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="versionId"></param>
        /// <param name="q"></param>
        /// <param name="filter"></param>
        /// <param name="diff"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>> GetRoutesAsync(
            string projectId,
            string? versionId = default,
            string? q = default,
            global::Vercel.GetRoutesFilter? filter = default,
            global::Vercel.OneOf<bool?, global::Vercel.GetRoutesDiff2?>? diff = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
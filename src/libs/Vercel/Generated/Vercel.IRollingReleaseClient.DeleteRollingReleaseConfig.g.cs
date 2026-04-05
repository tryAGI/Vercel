#nullable enable

namespace Vercel
{
    public partial interface IRollingReleaseClient
    {
        /// <summary>
        /// Delete rolling release configuration<br/>
        /// Disable Rolling Releases for a project means that future deployments will not undergo a rolling release. Changing the config never alters a rollout that's already in-flight—it only affects the next production deployment. If you want to also stop the current rollout, call this endpoint to disable the feature, and then call either the /complete or /abort endpoint.
        /// </summary>
        /// <param name="idOrName">
        /// Project ID or project name (URL-encoded)
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteRollingReleaseConfigResponse> DeleteRollingReleaseConfigAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
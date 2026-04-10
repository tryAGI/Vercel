#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Points all production domains for a project to the given deploy<br/>
        /// Allows users to promote a deployment to production. Note: This does NOT rebuild the deployment. If you need that, then call create-deployments endpoint.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task RequestPromoteAsync(
            string projectId,
            string deploymentId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
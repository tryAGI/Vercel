#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// Create a check run<br/>
        /// Creates a new check run for a deployment.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateDeploymentCheckRunResponse> CreateDeploymentCheckRunAsync(
            string deploymentId,

            global::Vercel.CreateDeploymentCheckRunRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a check run<br/>
        /// Creates a new check run for a deployment.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="checkId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateDeploymentCheckRunResponse> CreateDeploymentCheckRunAsync(
            string deploymentId,
            string checkId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
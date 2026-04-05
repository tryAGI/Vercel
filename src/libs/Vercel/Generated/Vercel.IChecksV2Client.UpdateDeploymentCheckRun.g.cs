#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// Update a check run<br/>
        /// Update an existing check run for a deployment.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="checkRunId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateDeploymentCheckRunResponse> UpdateDeploymentCheckRunAsync(
            string deploymentId,
            string checkRunId,

            global::Vercel.UpdateDeploymentCheckRunRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a check run<br/>
        /// Update an existing check run for a deployment.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="checkRunId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="externalId"></param>
        /// <param name="externalUrl"></param>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="conclusionText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateDeploymentCheckRunResponse> UpdateDeploymentCheckRunAsync(
            string deploymentId,
            string checkRunId,
            string? teamId = default,
            string? slug = default,
            string? externalId = default,
            string? externalUrl = default,
            global::Vercel.UpdateDeploymentCheckRunRequestStatus? status = default,
            object? output = default,
            double? completedAt = default,
            global::Vercel.UpdateDeploymentCheckRunRequestConclusion? conclusion = default,
            string? conclusionText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
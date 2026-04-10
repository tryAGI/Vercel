#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Updates the description for a rollback<br/>
        /// Updates the reason for a rollback, without changing the rollback status itself.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionAsync(
            string projectId,
            string deploymentId,

            global::Vercel.UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the description for a rollback<br/>
        /// Updates the reason for a rollback, without changing the rollback status itself.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="description">
        /// The reason for the rollback
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionAsync(
            string projectId,
            string deploymentId,
            string? description = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
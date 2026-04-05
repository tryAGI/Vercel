#nullable enable

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Update deployment integration action<br/>
        /// Updates the deployment integration action for the specified integration installation
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="action"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateIntegrationDeploymentActionAsync(
            string deploymentId,
            string integrationConfigurationId,
            string resourceId,
            string action,

            global::Vercel.UpdateIntegrationDeploymentActionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update deployment integration action<br/>
        /// Updates the deployment integration action for the specified integration installation
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="action"></param>
        /// <param name="status"></param>
        /// <param name="statusText"></param>
        /// <param name="statusUrl"></param>
        /// <param name="outcomes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateIntegrationDeploymentActionAsync(
            string deploymentId,
            string integrationConfigurationId,
            string resourceId,
            string action,
            global::Vercel.UpdateIntegrationDeploymentActionRequestStatus? status = default,
            string? statusText = default,
            string? statusUrl = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcome>? outcomes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
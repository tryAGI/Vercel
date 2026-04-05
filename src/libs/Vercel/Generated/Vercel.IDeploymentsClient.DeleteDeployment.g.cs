#nullable enable

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Delete a Deployment<br/>
        /// This API allows you to delete a deployment, either by supplying its `id` in the URL or the `url` of the deployment as a query parameter. You can obtain the ID, for example, by listing all deployments.
        /// </summary>
        /// <param name="id">
        /// The ID of the deployment to be deleted<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
        /// </param>
        /// <param name="url">
        /// A Deployment or Alias URL. In case it is passed, the ID will be ignored<br/>
        /// Example: https://files-orcin-xi.vercel.app/
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteDeploymentResponse> DeleteDeploymentAsync(
            string id,
            string? url = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
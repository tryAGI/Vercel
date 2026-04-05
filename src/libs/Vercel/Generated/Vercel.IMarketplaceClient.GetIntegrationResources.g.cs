#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Get Integration Resources<br/>
        /// Get all resources for a given installation ID.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetIntegrationResourcesResponse> GetIntegrationResourcesAsync(
            string integrationConfigurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
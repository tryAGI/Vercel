#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Create one or multiple experimentation items<br/>
        /// Create one or multiple experimentation items
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create one or multiple experimentation items<br/>
        /// Create one or multiple experimentation items
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="items"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsAsync(
            string integrationConfigurationId,
            string resourceId,
            global::System.Collections.Generic.IList<global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem> items,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
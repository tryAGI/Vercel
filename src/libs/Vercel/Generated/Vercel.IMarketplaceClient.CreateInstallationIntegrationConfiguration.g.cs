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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateInstallationIntegrationConfigurationAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create one or multiple experimentation items<br/>
        /// Create one or multiple experimentation items
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="items"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateInstallationIntegrationConfigurationAsync(
            string integrationConfigurationId,
            string resourceId,
            global::System.Collections.Generic.IList<global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem> items,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Delete an existing experimentation item<br/>
        /// Delete an existing experimentation item
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteInstallationIntegrationConfigurationAsync(
            string integrationConfigurationId,
            string resourceId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
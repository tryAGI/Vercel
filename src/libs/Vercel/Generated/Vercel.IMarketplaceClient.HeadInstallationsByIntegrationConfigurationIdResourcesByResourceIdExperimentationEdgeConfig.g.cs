#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Get the data of a user-provided Edge Config<br/>
        /// When the user enabled Edge Config syncing, then this endpoint can be used by the partner to fetch the contents of the Edge Config.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponse> HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigAsync(
            string integrationConfigurationId,
            string resourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
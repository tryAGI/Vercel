#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Push data into a user-provided Global Config<br/>
        /// When the user enabled Global Config syncing, then this endpoint can be used by the partner to push their configuration data into the relevant Global Config.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse> ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Push data into a user-provided Global Config<br/>
        /// When the user enabled Global Config syncing, then this endpoint can be used by the partner to push their configuration data into the relevant Global Config.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse>> ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigAsResponseAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Push data into a user-provided Global Config<br/>
        /// When the user enabled Global Config syncing, then this endpoint can be used by the partner to push their configuration data into the relevant Global Config.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse> ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigAsync(
            string integrationConfigurationId,
            string resourceId,
            object data,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
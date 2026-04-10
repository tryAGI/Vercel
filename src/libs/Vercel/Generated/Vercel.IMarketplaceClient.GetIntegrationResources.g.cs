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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetIntegrationResourcesResponse> GetIntegrationResourcesAsync(
            string integrationConfigurationId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
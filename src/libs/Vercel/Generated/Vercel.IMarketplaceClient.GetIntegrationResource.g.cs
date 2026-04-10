#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Get Integration Resource<br/>
        /// Get a resource by its partner ID.
        /// </summary>
        /// <param name="integrationConfigurationId">
        /// The ID of the integration configuration (installation) the resource belongs to
        /// </param>
        /// <param name="resourceId">
        /// The ID provided by the 3rd party provider for the given resource
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetIntegrationResourceResponse> GetIntegrationResourceAsync(
            string integrationConfigurationId,
            string resourceId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
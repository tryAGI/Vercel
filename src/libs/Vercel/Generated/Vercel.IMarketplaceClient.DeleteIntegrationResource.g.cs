#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Delete Integration Resource<br/>
        /// Delete a resource owned by the selected installation ID.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteIntegrationResourceAsync(
            string integrationConfigurationId,
            string resourceId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
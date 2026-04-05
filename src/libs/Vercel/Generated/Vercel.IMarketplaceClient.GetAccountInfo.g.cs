#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Get Account Information<br/>
        /// Fetches the best account or user’s contact info
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetAccountInfoResponse> GetAccountInfoAsync(
            string integrationConfigurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
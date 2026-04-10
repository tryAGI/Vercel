#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get TLD price data<br/>
        /// Get price data for a specific TLD. This only reflects base prices for the given TLD. Premium domains may have different prices. Use the [Get price data for a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/get-price-data-for-a-domain) endpoint to get the price data for a specific domain.
        /// </summary>
        /// <param name="tld">
        /// A valid TLD name
        /// </param>
        /// <param name="years">
        /// The number of years to get the price for. If not provided, the minimum number of years for the TLD will be used.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetTldPriceResponse> GetTldPriceAsync(
            string tld,
            string? years = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
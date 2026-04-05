#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get price data for a domain<br/>
        /// Get price data for a specific domain
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="years">
        /// The number of years to get the price for. If not provided, the minimum number of years for the TLD will be used.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetDomainPriceResponse> GetDomainPriceAsync(
            string domain,
            string? years = default,
            string? teamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
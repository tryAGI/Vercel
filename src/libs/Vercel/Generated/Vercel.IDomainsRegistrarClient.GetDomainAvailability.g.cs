#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get availability for a domain<br/>
        /// Get availability for a specific domain. If the domain is available, it can be purchased using the [Buy a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/buy-a-domain) endpoint or the [Buy multiple domains](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/buy-multiple-domains) endpoint.
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetDomainAvailabilityResponse> GetDomainAvailabilityAsync(
            string domain,
            string? teamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
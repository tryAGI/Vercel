#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Transfer-in a domain<br/>
        /// Transfer a domain in from another registrar
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.TransferInDomainResponse> TransferInDomainAsync(
            string domain,

            global::Vercel.TransferInDomainRequest request,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer-in a domain<br/>
        /// Transfer a domain in from another registrar
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="authCode">
        /// The auth code for the domain. You must obtain this code from the losing registrar.
        /// </param>
        /// <param name="autoRenew">
        /// Whether the domain should be auto-renewed before it expires. This can be configured later through the Vercel Dashboard or the [Update auto-renew for a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/update-auto-renew-for-a-domain) endpoint.
        /// </param>
        /// <param name="years">
        /// The number of years to renew the domain for once it is transferred in. This must be a valid number of transfer years for the TLD.
        /// </param>
        /// <param name="expectedPrice"></param>
        /// <param name="contactInformation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.TransferInDomainResponse> TransferInDomainAsync(
            string domain,
            string authCode,
            bool autoRenew,
            double years,
            double expectedPrice,
            global::Vercel.TransferInDomainRequestContactInformation contactInformation,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
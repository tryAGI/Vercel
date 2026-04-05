#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Renew a domain<br/>
        /// Renew a domain
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RenewDomainResponse> RenewDomainAsync(
            string domain,

            global::Vercel.RenewDomainRequest request,
            string? teamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Renew a domain<br/>
        /// Renew a domain
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="years">
        /// The number of years to renew the domain for.
        /// </param>
        /// <param name="expectedPrice"></param>
        /// <param name="contactInformation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RenewDomainResponse> RenewDomainAsync(
            string domain,
            double years,
            double expectedPrice,
            string? teamId = default,
            global::Vercel.RenewDomainRequestContactInformation? contactInformation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get a domain's transfer status<br/>
        /// Get the transfer status for a domain
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetDomainTransferInResponse> GetDomainTransferInAsync(
            string domain,
            string? teamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
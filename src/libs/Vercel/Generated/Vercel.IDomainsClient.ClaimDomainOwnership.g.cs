#nullable enable

namespace Vercel
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Claim Domain Ownership<br/>
        /// Claim ownership of a domain for the authenticated team by verifying a TXT record. The caller must first add a TXT record to `_vercel.{domain}` (obtained from GET /domains/:domain/verification), then call this endpoint to complete the ownership transfer. If the TXT record is verified, the domain ownership will be transferred to the caller's team, even if the domain is currently owned by another user or team.
        /// </summary>
        /// <param name="domain">
        /// The domain name to claim ownership of<br/>
        /// Example: example.com
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ClaimDomainOwnershipResponse> ClaimDomainOwnershipAsync(
            string domain,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claim Domain Ownership<br/>
        /// Claim ownership of a domain for the authenticated team by verifying a TXT record. The caller must first add a TXT record to `_vercel.{domain}` (obtained from GET /domains/:domain/verification), then call this endpoint to complete the ownership transfer. If the TXT record is verified, the domain ownership will be transferred to the caller's team, even if the domain is currently owned by another user or team.
        /// </summary>
        /// <param name="domain">
        /// The domain name to claim ownership of<br/>
        /// Example: example.com
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ClaimDomainOwnershipResponse>> ClaimDomainOwnershipAsResponseAsync(
            string domain,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
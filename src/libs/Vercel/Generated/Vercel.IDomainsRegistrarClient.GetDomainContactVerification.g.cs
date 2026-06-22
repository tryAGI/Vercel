#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get contact verification status for a domain<br/>
        /// Get the registrant contact verification status for a domain. Use this after purchasing a domain to determine whether the contact has been verified. Note that a bought_too_recently error will be returned if the domain was bought less than 30 minutes before the request.
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AnyOf<global::Vercel.ContactVerified, global::Vercel.ContactPendingVerification>> GetDomainContactVerificationAsync(
            string domain,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get contact verification status for a domain<br/>
        /// Get the registrant contact verification status for a domain. Use this after purchasing a domain to determine whether the contact has been verified. Note that a bought_too_recently error will be returned if the domain was bought less than 30 minutes before the request.
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AnyOf<global::Vercel.ContactVerified, global::Vercel.ContactPendingVerification>>> GetDomainContactVerificationAsResponseAsync(
            string domain,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
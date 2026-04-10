#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get contact info schema<br/>
        /// Some TLDs require additional contact information. Use this endpoint to get the schema for the tld-specific contact information for a domain.
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
        global::System.Threading.Tasks.Task<string> GetContactInfoSchemaAsync(
            string domain,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
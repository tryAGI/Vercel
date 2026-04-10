#nullable enable

namespace Vercel
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Remove a domain by name<br/>
        /// Delete a previously registered domain name from Vercel. Deleting a domain will automatically remove any associated aliases.
        /// </summary>
        /// <param name="domain">
        /// The name of the domain.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.DeleteDomainResponse> DeleteDomainAsync(
            string domain,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Get Information for a Single Domain<br/>
        /// Get information for a single domain in an account or team.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetDomainResponse> GetDomainAsync(
            string domain,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
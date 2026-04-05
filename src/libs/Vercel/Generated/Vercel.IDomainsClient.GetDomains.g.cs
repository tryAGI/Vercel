#nullable enable

namespace Vercel
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// List all the domains<br/>
        /// Retrieves a list of domains registered for the authenticated user or team. By default it returns the last 20 domains if no limit is provided.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of domains to list from a request.<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Get domains created after this JavaScript timestamp.<br/>
        /// Example: 1609499532000L
        /// </param>
        /// <param name="until">
        /// Get domains created before this JavaScript timestamp.<br/>
        /// Example: 1612264332000L
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetDomainsResponse> GetDomainsAsync(
            double? limit = default,
            double? since = default,
            double? until = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
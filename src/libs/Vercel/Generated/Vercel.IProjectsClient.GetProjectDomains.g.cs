#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieve project domains by project by id or name<br/>
        /// Retrieve the domains associated with a given project by passing either the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="production">
        /// Filters only production domains when set to `true`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="target">
        /// Filters on the target of the domain. Can be either \"production\", \"preview\"
        /// </param>
        /// <param name="customEnvironmentId">
        /// The unique custom environment identifier within the project<br/>
        /// Example: env_123abc4567
        /// </param>
        /// <param name="gitBranch">
        /// Filters domains based on specific branch.
        /// </param>
        /// <param name="redirects">
        /// Excludes redirect project domains when \"false\". Includes redirect project domains when \"true\" (default).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="redirect">
        /// Filters domains based on their redirect target.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="verified">
        /// Filters domains based on their verification status.
        /// </param>
        /// <param name="limit">
        /// Maximum number of domains to list from a request (max 100).<br/>
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
        /// <param name="order">
        /// Domains sort order by createdAt<br/>
        /// Default Value: DESC
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.GetProjectDomainsResponseVariant1, global::Vercel.GetProjectDomainsResponseVariant2>> GetProjectDomainsAsync(
            string idOrName,
            global::Vercel.GetProjectDomainsProduction? production = default,
            global::Vercel.GetProjectDomainsTarget? target = default,
            string? customEnvironmentId = default,
            string? gitBranch = default,
            global::Vercel.GetProjectDomainsRedirects? redirects = default,
            string? redirect = default,
            global::Vercel.GetProjectDomainsVerified? verified = default,
            double? limit = default,
            double? since = default,
            double? until = default,
            global::Vercel.GetProjectDomainsOrder? order = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
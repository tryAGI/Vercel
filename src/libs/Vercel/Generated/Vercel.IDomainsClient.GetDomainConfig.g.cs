#nullable enable

namespace Vercel
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Get a Domain's configuration<br/>
        /// Get a Domain's configuration.
        /// </summary>
        /// <param name="domain">
        /// The name of the domain.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="projectIdOrName">
        /// The project id or name that will be associated with the domain. Use this when the domain is not yet associated with a project.
        /// </param>
        /// <param name="strict">
        /// When true, the response will only include the nameservers assigned directly to the specified domain. When false and there are no nameservers assigned directly to the specified domain, the response will include the nameservers of the domain's parent zone.
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
        global::System.Threading.Tasks.Task<global::Vercel.GetDomainConfigResponse> GetDomainConfigAsync(
            string domain,
            string? projectIdOrName = default,
            global::Vercel.GetDomainConfigStrict? strict = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update a project domain<br/>
        /// Update a project domain's configuration, including the name, git branch and redirect of the domain.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="domain">
        /// The project domain name<br/>
        /// Example: www.example.com
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectDomainResponse> UpdateProjectDomainAsync(
            string idOrName,
            string domain,

            global::Vercel.UpdateProjectDomainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project domain<br/>
        /// Update a project domain's configuration, including the name, git branch and redirect of the domain.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="domain">
        /// The project domain name<br/>
        /// Example: www.example.com
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="gitBranch">
        /// Git branch to link the project domain<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="redirect">
        /// Target destination domain for redirect<br/>
        /// Example: foobar.com
        /// </param>
        /// <param name="redirectStatusCode">
        /// Status code for domain redirect<br/>
        /// Example: 307
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectDomainResponse> UpdateProjectDomainAsync(
            string idOrName,
            string domain,
            string? teamId = default,
            string? slug = default,
            string? gitBranch = default,
            string? redirect = default,
            int? redirectStatusCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
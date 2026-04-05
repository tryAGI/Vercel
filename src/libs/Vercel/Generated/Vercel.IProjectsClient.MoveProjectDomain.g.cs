#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Move a project domain<br/>
        /// Move one project's domain to another project. Also allows the move of all redirects pointed to that domain in the same project.
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
        global::System.Threading.Tasks.Task<global::Vercel.MoveProjectDomainResponse> MoveProjectDomainAsync(
            string idOrName,
            string domain,

            global::Vercel.MoveProjectDomainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move a project domain<br/>
        /// Move one project's domain to another project. Also allows the move of all redirects pointed to that domain in the same project.
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
        /// <param name="projectId">
        /// The unique target project identifier<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
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
        global::System.Threading.Tasks.Task<global::Vercel.MoveProjectDomainResponse> MoveProjectDomainAsync(
            string idOrName,
            string domain,
            string projectId,
            string? teamId = default,
            string? slug = default,
            string? gitBranch = default,
            string? redirect = default,
            int? redirectStatusCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
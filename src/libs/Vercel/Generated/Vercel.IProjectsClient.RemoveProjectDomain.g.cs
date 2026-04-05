#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Remove a domain from a project<br/>
        /// Remove a domain from a project by passing the domain name and by specifying the project by either passing the project `id` or `name` in the URL.
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
        global::System.Threading.Tasks.Task<string> RemoveProjectDomainAsync(
            string idOrName,
            string domain,

            global::Vercel.RemoveProjectDomainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a domain from a project<br/>
        /// Remove a domain from a project by passing the domain name and by specifying the project by either passing the project `id` or `name` in the URL.
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
        /// <param name="removeRedirects">
        /// Whether to remove all domains from this project that redirect to the domain being removed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveProjectDomainAsync(
            string idOrName,
            string domain,
            string? teamId = default,
            string? slug = default,
            bool? removeRedirects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
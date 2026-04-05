#nullable enable

namespace Vercel
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List git repositories linked to namespace by provider<br/>
        /// Lists git repositories linked to a namespace `id` for a supported provider. A specific namespace `id` can be obtained via the `git-namespaces`  endpoint. Supported providers are `github`, `gitlab` and `bitbucket`. If the provider or namespace is not provided, it will try to obtain it from the user that authenticated the request.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="namespaceId"></param>
        /// <param name="provider"></param>
        /// <param name="installationId"></param>
        /// <param name="host">
        /// The custom Git host if using a custom Git provider, like GitHub Enterprise Server<br/>
        /// Example: ghes-test.now.systems
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.SearchRepoResponseVariant2>> SearchRepoAsync(
            string? query = default,
            global::Vercel.OneOf<string, double?>? namespaceId = default,
            global::Vercel.SearchRepoProvider? provider = default,
            string? installationId = default,
            string? host = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
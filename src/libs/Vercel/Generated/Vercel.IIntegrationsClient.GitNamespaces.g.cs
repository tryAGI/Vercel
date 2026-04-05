#nullable enable

namespace Vercel
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List git namespaces by provider<br/>
        /// Lists git namespaces for a supported provider. Supported providers are `github`, `gitlab` and `bitbucket`. If the provider is not provided, it will try to obtain it from the user that authenticated the request.
        /// </summary>
        /// <param name="host">
        /// The custom Git host if using a custom Git provider, like GitHub Enterprise Server<br/>
        /// Example: ghes-test.now.systems
        /// </param>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.GitNamespacesResponseItem>> GitNamespacesAsync(
            string? host = default,
            global::Vercel.GitNamespacesProvider? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
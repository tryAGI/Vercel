#nullable enable

namespace Vercel
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Add an existing domain to the Vercel platform<br/>
        /// This endpoint is used for adding a new apex domain name with Vercel for the authenticating user. Note: This endpoint is no longer used for initiating domain transfers from external registrars to Vercel. For this, please use the endpoint [Transfer-in a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/transfer-in-a-domain).
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateOrTransferDomainResponse> CreateOrTransferDomainAsync(

            global::Vercel.CreateOrTransferDomainRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add an existing domain to the Vercel platform<br/>
        /// This endpoint is used for adding a new apex domain name with Vercel for the authenticating user. Note: This endpoint is no longer used for initiating domain transfers from external registrars to Vercel. For this, please use the endpoint [Transfer-in a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/transfer-in-a-domain).
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="method">
        /// The domain operation to perform. It can be either `add` or `move-in`.<br/>
        /// Example: add
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateOrTransferDomainResponse> CreateOrTransferDomainAsync(
            string? teamId = default,
            string? slug = default,
            string? method = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
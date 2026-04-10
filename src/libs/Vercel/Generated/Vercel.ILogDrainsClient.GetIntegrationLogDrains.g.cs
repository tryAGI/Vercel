#nullable enable

namespace Vercel
{
    public partial interface ILogDrainsClient
    {
        /// <summary>
        /// Retrieves a list of Integration log drains (deprecated)<br/>
        /// Retrieves a list of all Integration log drains that are defined for the authenticated user or team. When using an OAuth2 token, the list is limited to log drains created by the authenticated integration.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.GetIntegrationLogDrainsResponseItem>> GetIntegrationLogDrainsAsync(
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
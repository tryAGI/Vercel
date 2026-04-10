#nullable enable

namespace Vercel
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Get configurations for the authenticated user or team<br/>
        /// Allows to retrieve all configurations for an authenticated integration. When the `project` view is used, configurations generated for the authorization flow will be filtered out of the results.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="installationType"></param>
        /// <param name="integrationIdOrSlug">
        /// ID of the integration
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetConfigurationsResponseVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetConfigurationsResponseVariant2Item>>> GetConfigurationsAsync(
            global::Vercel.GetConfigurationsView view,
            global::Vercel.GetConfigurationsInstallationType? installationType = default,
            string? integrationIdOrSlug = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
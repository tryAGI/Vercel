#nullable enable

namespace Vercel
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Retrieve an integration configuration<br/>
        /// Allows to retrieve a the configuration with the provided id in case it exists. The authenticated user or team must be the owner of the config in order to access it.
        /// </summary>
        /// <param name="id">
        /// ID of the configuration to check<br/>
        /// Example: icfg_cuwj0AdCdH3BwWT4LPijCC7t
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.GetConfigurationResponseVariant1, global::Vercel.GetConfigurationResponseVariant2, global::Vercel.GetConfigurationResponseVariant3>> GetConfigurationAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
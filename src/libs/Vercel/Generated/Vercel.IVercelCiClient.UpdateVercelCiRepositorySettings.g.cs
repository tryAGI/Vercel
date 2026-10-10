#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Enable or disable Vercel CI for a connected repository<br/>
        /// Update Repository Settings
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="organizationId"></param>
        /// <param name="repository"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateVercelCiRepositorySettingsResponse> UpdateVercelCiRepositorySettingsAsync(
            global::Vercel.UpdateVercelCiRepositorySettingsProvider provider,
            string organizationId,
            string repository,

            global::Vercel.UpdateVercelCiRepositorySettingsRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable Vercel CI for a connected repository<br/>
        /// Update Repository Settings
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="organizationId"></param>
        /// <param name="repository"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UpdateVercelCiRepositorySettingsResponse>> UpdateVercelCiRepositorySettingsAsResponseAsync(
            global::Vercel.UpdateVercelCiRepositorySettingsProvider provider,
            string organizationId,
            string repository,

            global::Vercel.UpdateVercelCiRepositorySettingsRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable Vercel CI for a connected repository<br/>
        /// Update Repository Settings
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="organizationId"></param>
        /// <param name="repository"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="ciEnabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateVercelCiRepositorySettingsResponse> UpdateVercelCiRepositorySettingsAsync(
            global::Vercel.UpdateVercelCiRepositorySettingsProvider provider,
            string organizationId,
            string repository,
            bool ciEnabled,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
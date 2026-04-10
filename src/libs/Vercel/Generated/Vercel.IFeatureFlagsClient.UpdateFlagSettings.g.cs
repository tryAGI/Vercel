#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Update project flag settings<br/>
        /// Update feature flag settings for a project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateFlagSettingsResponse> UpdateFlagSettingsAsync(
            string projectIdOrName,

            global::Vercel.UpdateFlagSettingsRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project flag settings<br/>
        /// Update feature flag settings for a project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="entities"></param>
        /// <param name="environments">
        /// The environments to sync
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateFlagSettingsResponse> UpdateFlagSettingsAsync(
            string projectIdOrName,
            string? teamId = default,
            string? slug = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsRequestEntitie>? entities = default,
            global::System.Collections.Generic.IList<string>? environments = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
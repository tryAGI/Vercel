#nullable enable

namespace Vercel
{
    public partial interface IRollingReleaseClient
    {
        /// <summary>
        /// Get the active rolling release information for a project<br/>
        /// Return the Rolling Release for a project, regardless of whether the rollout is active, aborted, or completed. If the feature is enabled but no deployment has occurred yet, null will be returned.
        /// </summary>
        /// <param name="idOrName">
        /// Project ID or project name (URL-encoded)
        /// </param>
        /// <param name="state">
        /// Filter by rolling release state
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
        global::System.Threading.Tasks.Task<global::Vercel.GetRollingReleaseResponse> GetRollingReleaseAsync(
            string idOrName,
            global::Vercel.GetRollingReleaseState? state = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
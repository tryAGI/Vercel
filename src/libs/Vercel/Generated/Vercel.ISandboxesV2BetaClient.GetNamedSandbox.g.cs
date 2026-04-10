#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Get a named sandbox<br/>
        /// Retrieves a named sandbox by name, including its current sandbox and routes. If the sandbox is stopped and resume is true, a new sandbox will be created from the most recent snapshot.
        /// </summary>
        /// <param name="name">
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="projectId">
        /// The project ID or name (required when not using OIDC token).<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="resume">
        /// Whether to automatically resume a stopped named sandbox by creating a new instance from its snapshot. Defaults to false.<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::Vercel.GetNamedSandboxResponse> GetNamedSandboxAsync(
            string name,
            string? projectId = default,
            bool? resume = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
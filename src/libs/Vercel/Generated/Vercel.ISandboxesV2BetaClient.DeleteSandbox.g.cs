#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Delete a sandbox<br/>
        /// Deletes a sandbox by name. If sandboxes are currently running, they will be stopped first. This operation deletes all sandbox entities with the given name, all associated snapshots, and the named sandbox metadata.
        /// </summary>
        /// <param name="name">
        /// The sandbox name to delete.<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="projectId">
        /// The project ID that owns the named sandbox. When provided, takes precedence over OIDC project context.
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
        global::System.Threading.Tasks.Task<global::Vercel.DeleteSandboxResponse> DeleteSandboxAsync(
            string name,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get a sandbox<br/>
        /// Retrieves detailed information about a specific sandbox, including its current status, resource configuration, and exposed routes.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to retrieve.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSandboxResponse> GetSandboxAsync(
            string sandboxId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
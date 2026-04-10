#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// List all checks for a project<br/>
        /// List all checks for a project, optionally filtered by target.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="blocks"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListProjectChecksResponse> ListProjectChecksAsync(
            string projectIdOrName,
            global::Vercel.ListProjectChecksBlocks? blocks = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
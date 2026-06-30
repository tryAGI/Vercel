#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Delete a repository<br/>
        /// Schedule a repository for deletion. The repository is marked so it disappears from list/get immediately; subscriber-vcr reclaims every image (manifests, blobs, tags and rows) and finally deletes the repository row asynchronously via the VcrRepositoryRemoved event.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRepositoryAsync(
            string projectId,
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a repository<br/>
        /// Schedule a repository for deletion. The repository is marked so it disappears from list/get immediately; subscriber-vcr reclaims every image (manifests, blobs, tags and rows) and finally deletes the repository row asynchronously via the VcrRepositoryRemoved event.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> DeleteRepositoryAsResponseAsync(
            string projectId,
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
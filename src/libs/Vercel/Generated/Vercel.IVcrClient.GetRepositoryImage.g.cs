#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Get a repository image<br/>
        /// Fetch an individual image from a repository, including its tags and Dockerfile history entries with discriminated layer details for UI rendering. The image may be addressed by its internal id (`image_...`) or by its manifest digest (`sha256:...`).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="imageIdOrDigest">
        /// The internal image id (`image_...`) or the image manifest digest (`sha256:...`).
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
        global::System.Threading.Tasks.Task<global::Vercel.GetRepositoryImageResponse> GetRepositoryImageAsync(
            string projectId,
            string idOrName,
            string imageIdOrDigest,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a repository image<br/>
        /// Fetch an individual image from a repository, including its tags and Dockerfile history entries with discriminated layer details for UI rendering. The image may be addressed by its internal id (`image_...`) or by its manifest digest (`sha256:...`).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="imageIdOrDigest">
        /// The internal image id (`image_...`) or the image manifest digest (`sha256:...`).
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetRepositoryImageResponse>> GetRepositoryImageAsResponseAsync(
            string projectId,
            string idOrName,
            string imageIdOrDigest,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
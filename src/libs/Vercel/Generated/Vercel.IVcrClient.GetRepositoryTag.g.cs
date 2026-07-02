#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Get a repository tag<br/>
        /// Fetch a single tag from a repository, including the backing image's metadata and VHS-readiness status.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="tag"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetRepositoryTagResponse> GetRepositoryTagAsync(
            string projectId,
            string idOrName,
            string tag,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a repository tag<br/>
        /// Fetch a single tag from a repository, including the backing image's metadata and VHS-readiness status.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="tag"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetRepositoryTagResponse>> GetRepositoryTagAsResponseAsync(
            string projectId,
            string idOrName,
            string tag,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
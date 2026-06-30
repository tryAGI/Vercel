#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// List repository tags<br/>
        /// List a repository's tags.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="sortBy">
        /// Field to sort the non-pinned tags by.<br/>
        /// Default Value: updatedAt
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to desc.<br/>
        /// Default Value: desc
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
        global::System.Threading.Tasks.Task<global::Vercel.ListRepositoryTagsResponse> ListRepositoryTagsAsync(
            string projectId,
            string idOrName,
            int? limit = default,
            string? cursor = default,
            global::Vercel.ListRepositoryTagsSortBy? sortBy = default,
            global::Vercel.ListRepositoryTagsSortOrder? sortOrder = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repository tags<br/>
        /// List a repository's tags.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="sortBy">
        /// Field to sort the non-pinned tags by.<br/>
        /// Default Value: updatedAt
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to desc.<br/>
        /// Default Value: desc
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListRepositoryTagsResponse>> ListRepositoryTagsAsResponseAsync(
            string projectId,
            string idOrName,
            int? limit = default,
            string? cursor = default,
            global::Vercel.ListRepositoryTagsSortBy? sortBy = default,
            global::Vercel.ListRepositoryTagsSortOrder? sortOrder = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
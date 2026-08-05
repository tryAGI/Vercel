#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// GET /v2/:teamSlug/:projectSlug/:repositoryName/tags/list List the tags in a repository.
        /// </summary>
        /// <param name="teamSlug">
        /// Single Docker repository team slug component.<br/>
        /// Example: team-slug
        /// </param>
        /// <param name="projectSlug">
        /// Single Docker repository project slug component.<br/>
        /// Example: project-slug
        /// </param>
        /// <param name="repositoryName">
        /// Single Docker repository name component.<br/>
        /// Example: nginx
        /// </param>
        /// <param name="n"></param>
        /// <param name="last">
        /// Opaque pagination cursor returned by a previous list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetByTeamSlugByProjectSlugByRepositoryNameTagsListResponse> GetByTeamSlugByProjectSlugByRepositoryNameTagsListAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            int? n = default,
            string? last = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GET /v2/:teamSlug/:projectSlug/:repositoryName/tags/list List the tags in a repository.
        /// </summary>
        /// <param name="teamSlug">
        /// Single Docker repository team slug component.<br/>
        /// Example: team-slug
        /// </param>
        /// <param name="projectSlug">
        /// Single Docker repository project slug component.<br/>
        /// Example: project-slug
        /// </param>
        /// <param name="repositoryName">
        /// Single Docker repository name component.<br/>
        /// Example: nginx
        /// </param>
        /// <param name="n"></param>
        /// <param name="last">
        /// Opaque pagination cursor returned by a previous list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetByTeamSlugByProjectSlugByRepositoryNameTagsListResponse>> GetByTeamSlugByProjectSlugByRepositoryNameTagsListAsResponseAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            int? n = default,
            string? last = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
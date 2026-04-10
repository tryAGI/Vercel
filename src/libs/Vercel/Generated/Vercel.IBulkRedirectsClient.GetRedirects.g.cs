#nullable enable

namespace Vercel
{
    public partial interface IBulkRedirectsClient
    {
        /// <summary>
        /// Gets project-level redirects.<br/>
        /// Get the version history for a project's bulk redirects
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="versionId"></param>
        /// <param name="q"></param>
        /// <param name="diff"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.GetRedirectsResponseVariant2, global::Vercel.GetRedirectsResponseVariant3>> GetRedirectsAsync(
            string projectId,
            string? versionId = default,
            string? q = default,
            global::Vercel.OneOf<bool?, global::Vercel.GetRedirectsDiff2?>? diff = default,
            int? page = default,
            int? perPage = default,
            global::Vercel.GetRedirectsSortBy? sortBy = default,
            global::Vercel.GetRedirectsSortOrder? sortOrder = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
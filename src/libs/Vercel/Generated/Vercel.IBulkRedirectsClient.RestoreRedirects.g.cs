#nullable enable

namespace Vercel
{
    public partial interface IBulkRedirectsClient
    {
        /// <summary>
        /// Restore staged project-level redirects to their production version.<br/>
        /// Restores the provided redirects in the staging version to the value in the production version. If no production version exists, removes the redirects from staging.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RestoreRedirectsResponse> RestoreRedirectsAsync(
            string projectId,

            global::Vercel.RestoreRedirectsRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore staged project-level redirects to their production version.<br/>
        /// Restores the provided redirects in the staging version to the value in the production version. If no production version exists, removes the redirects from staging.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name"></param>
        /// <param name="redirects">
        /// The redirects to restore. The source of the redirect is used to match the redirect to restore.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RestoreRedirectsResponse> RestoreRedirectsAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> redirects,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
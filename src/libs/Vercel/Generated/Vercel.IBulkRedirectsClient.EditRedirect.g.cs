#nullable enable

namespace Vercel
{
    public partial interface IBulkRedirectsClient
    {
        /// <summary>
        /// Edit a project-level redirect.<br/>
        /// Edits a single redirect identified by its source path. Stages a new change with the modified redirect and returns the alias for the new version in the response.
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
        global::System.Threading.Tasks.Task<global::Vercel.EditRedirectResponse> EditRedirectAsync(
            string projectId,

            global::Vercel.EditRedirectRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a project-level redirect.<br/>
        /// Edits a single redirect identified by its source path. Stages a new change with the modified redirect and returns the alias for the new version in the response.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name"></param>
        /// <param name="redirect">
        /// The redirect object to edit. The source field is used to match the redirect to modify.
        /// </param>
        /// <param name="restore">
        /// If true, restores the redirect from the latest production version to staging.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.EditRedirectResponse> EditRedirectAsync(
            string projectId,
            global::Vercel.EditRedirectRequestRedirect redirect,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            bool? restore = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
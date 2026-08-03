#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Add a repository permission<br/>
        /// Grant a team access to a VCR repository. Sharing applies to the whole repository.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AddRepositoryPermissionResponse> AddRepositoryPermissionAsync(
            string projectId,
            string idOrName,

            global::Vercel.AddRepositoryPermissionRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a repository permission<br/>
        /// Grant a team access to a VCR repository. Sharing applies to the whole repository.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AddRepositoryPermissionResponse>> AddRepositoryPermissionAsResponseAsync(
            string projectId,
            string idOrName,

            global::Vercel.AddRepositoryPermissionRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a repository permission<br/>
        /// Grant a team access to a VCR repository. Sharing applies to the whole repository.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="idOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestTeamId">
        /// ID of a team that is granted access to a repository.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </param>
        /// <param name="teamSlug">
        /// Slug of a team that is granted access to a repository.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AddRepositoryPermissionResponse> AddRepositoryPermissionAsync(
            string projectId,
            string idOrName,
            string? teamId = default,
            string? slug = default,
            string? requestTeamId = default,
            string? teamSlug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
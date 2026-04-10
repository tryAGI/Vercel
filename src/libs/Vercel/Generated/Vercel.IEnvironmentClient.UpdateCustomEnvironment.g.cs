#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Update a custom environment<br/>
        /// Update a custom environment for the project. Must not be named 'Production' or 'Preview'.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="environmentSlugOrId">
        /// The unique custom environment identifier within the project
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateCustomEnvironmentResponse> UpdateCustomEnvironmentAsync(
            string idOrName,
            string environmentSlugOrId,

            global::Vercel.UpdateCustomEnvironmentRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom environment<br/>
        /// Update a custom environment for the project. Must not be named 'Production' or 'Preview'.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="environmentSlugOrId">
        /// The unique custom environment identifier within the project
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestSlug">
        /// The slug of the custom environment.
        /// </param>
        /// <param name="description">
        /// Description of the custom environment. This is optional.
        /// </param>
        /// <param name="branchMatcher">
        /// How we want to determine a matching branch. This is optional.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateCustomEnvironmentResponse> UpdateCustomEnvironmentAsync(
            string idOrName,
            string environmentSlugOrId,
            string? teamId = default,
            string? slug = default,
            string? requestSlug = default,
            string? description = default,
            global::Vercel.UpdateCustomEnvironmentRequestBranchMatcher? branchMatcher = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Create a custom environment for the current project.<br/>
        /// Creates a custom environment for the current project. Cannot be named 'Production' or 'Preview'.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateCustomEnvironmentResponse> CreateCustomEnvironmentAsync(
            string idOrName,

            global::Vercel.CreateCustomEnvironmentRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom environment for the current project.<br/>
        /// Creates a custom environment for the current project. Cannot be named 'Production' or 'Preview'.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestSlug">
        /// The slug of the custom environment to create.
        /// </param>
        /// <param name="description">
        /// Description of the custom environment. This is optional.
        /// </param>
        /// <param name="branchMatcher">
        /// How we want to determine a matching branch. This is optional.
        /// </param>
        /// <param name="copyEnvVarsFrom">
        /// Where to copy environment variables from. This is optional.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateCustomEnvironmentResponse> CreateCustomEnvironmentAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            string? requestSlug = default,
            string? description = default,
            global::Vercel.CreateCustomEnvironmentRequestBranchMatcher? branchMatcher = default,
            string? copyEnvVarsFrom = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
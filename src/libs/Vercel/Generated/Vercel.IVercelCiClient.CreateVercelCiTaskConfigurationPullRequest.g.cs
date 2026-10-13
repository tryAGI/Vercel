#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Create a GitHub pull request that adds Vercel CI tags for the completed analysis<br/>
        /// Create task configuration pull request
        /// </summary>
        /// <param name="analysisId"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateVercelCiTaskConfigurationPullRequestResponse> CreateVercelCiTaskConfigurationPullRequestAsync(
            string analysisId,

            global::Vercel.CreateVercelCiTaskConfigurationPullRequestRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a GitHub pull request that adds Vercel CI tags for the completed analysis<br/>
        /// Create task configuration pull request
        /// </summary>
        /// <param name="analysisId"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateVercelCiTaskConfigurationPullRequestResponse>> CreateVercelCiTaskConfigurationPullRequestAsResponseAsync(
            string analysisId,

            global::Vercel.CreateVercelCiTaskConfigurationPullRequestRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a GitHub pull request that adds Vercel CI tags for the completed analysis<br/>
        /// Create task configuration pull request
        /// </summary>
        /// <param name="analysisId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="tasks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateVercelCiTaskConfigurationPullRequestResponse> CreateVercelCiTaskConfigurationPullRequestAsync(
            string analysisId,
            global::System.Collections.Generic.IList<global::Vercel.CreateVercelCiTaskConfigurationPullRequestRequestTask> tasks,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
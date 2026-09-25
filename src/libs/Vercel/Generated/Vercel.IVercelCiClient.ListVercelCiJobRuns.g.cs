#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// List all runs for a job definition<br/>
        /// List Job Runs
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListVercelCiJobRunsResponse> ListVercelCiJobRunsAsync(
            string invocationId,
            string attempt,
            string jobDefinitionId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all runs for a job definition<br/>
        /// List Job Runs
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListVercelCiJobRunsResponse>> ListVercelCiJobRunsAsResponseAsync(
            string invocationId,
            string attempt,
            string jobDefinitionId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
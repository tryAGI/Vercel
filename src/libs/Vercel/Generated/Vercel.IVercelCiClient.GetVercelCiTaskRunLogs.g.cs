#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Get log lines for a specific task run attempt<br/>
        /// Get Task Run Logs With `follow=1` the response is a newline-delimited JSON stream of log lines that ends once the task run has finished and its logs are flushed, or when the stream reaches its maximum duration.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="taskDefinitionId"></param>
        /// <param name="taskRunAttempt"></param>
        /// <param name="follow">
        /// When 1, stream log lines as newline-delimited JSON until the task run finishes.
        /// </param>
        /// <param name="since"></param>
        /// <param name="level">
        /// Only return log lines with one of these levels.
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
        global::System.Threading.Tasks.Task<global::Vercel.GetVercelCiTaskRunLogsResponse> GetVercelCiTaskRunLogsAsync(
            string invocationId,
            string attempt,
            string jobDefinitionId,
            string runAttempt,
            string taskDefinitionId,
            string taskRunAttempt,
            double? follow = default,
            double? since = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskRunLogsLevelItem>? level = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get log lines for a specific task run attempt<br/>
        /// Get Task Run Logs With `follow=1` the response is a newline-delimited JSON stream of log lines that ends once the task run has finished and its logs are flushed, or when the stream reaches its maximum duration.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="taskDefinitionId"></param>
        /// <param name="taskRunAttempt"></param>
        /// <param name="follow">
        /// When 1, stream log lines as newline-delimited JSON until the task run finishes.
        /// </param>
        /// <param name="since"></param>
        /// <param name="level">
        /// Only return log lines with one of these levels.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetVercelCiTaskRunLogsResponse>> GetVercelCiTaskRunLogsAsResponseAsync(
            string invocationId,
            string attempt,
            string jobDefinitionId,
            string runAttempt,
            string taskDefinitionId,
            string taskRunAttempt,
            double? follow = default,
            double? since = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskRunLogsLevelItem>? level = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
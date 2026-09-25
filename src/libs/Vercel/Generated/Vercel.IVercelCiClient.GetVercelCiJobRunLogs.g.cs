#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Get log lines for a specific job run attempt<br/>
        /// Get Job Run Logs
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="follow"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.GetVercelCiJobRunLogsResponse> GetVercelCiJobRunLogsAsync(
            string invocationId,
            string attempt,
            string jobDefinitionId,
            string runAttempt,
            double? follow = default,
            double? since = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiJobRunLogsLevelItem>? level = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get log lines for a specific job run attempt<br/>
        /// Get Job Run Logs
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="follow"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetVercelCiJobRunLogsResponse>> GetVercelCiJobRunLogsAsResponseAsync(
            string invocationId,
            string attempt,
            string jobDefinitionId,
            string runAttempt,
            double? follow = default,
            double? since = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiJobRunLogsLevelItem>? level = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
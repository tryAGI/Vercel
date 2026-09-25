#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Get log lines for the tasks of an invocation attempt<br/>
        /// Returns log lines for the tasks of an invocation attempt in a single request, grouped by task. Tasks can be narrowed by name and by conclusion, for example `conclusion=failed` to fetch only the logs of failed tasks. With `search`, every matching task is searched at once and only tasks with matching lines are returned.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="task">
        /// Only return tasks with one of these names (e.g., \"web#test\").
        /// </param>
        /// <param name="conclusion">
        /// Only return completed tasks with one of these conclusions.
        /// </param>
        /// <param name="level">
        /// Only return log lines with one of these levels.
        /// </param>
        /// <param name="search">
        /// Only return log lines containing this text, ignoring case. Tasks without matching lines are left out, `limit` is ignored, and at most 1000 lines are returned.
        /// </param>
        /// <param name="limit">
        /// Maximum number of tasks to return (default: 10, max: 25).
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
        global::System.Threading.Tasks.Task<global::Vercel.GetVercelCiTaskLogsResponse> GetVercelCiTaskLogsAsync(
            string invocationId,
            string attempt,
            global::System.Collections.Generic.IList<string>? task = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsConclusionItem>? conclusion = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsLevelItem>? level = default,
            string? search = default,
            double? limit = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get log lines for the tasks of an invocation attempt<br/>
        /// Returns log lines for the tasks of an invocation attempt in a single request, grouped by task. Tasks can be narrowed by name and by conclusion, for example `conclusion=failed` to fetch only the logs of failed tasks. With `search`, every matching task is searched at once and only tasks with matching lines are returned.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="task">
        /// Only return tasks with one of these names (e.g., \"web#test\").
        /// </param>
        /// <param name="conclusion">
        /// Only return completed tasks with one of these conclusions.
        /// </param>
        /// <param name="level">
        /// Only return log lines with one of these levels.
        /// </param>
        /// <param name="search">
        /// Only return log lines containing this text, ignoring case. Tasks without matching lines are left out, `limit` is ignored, and at most 1000 lines are returned.
        /// </param>
        /// <param name="limit">
        /// Maximum number of tasks to return (default: 10, max: 25).
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetVercelCiTaskLogsResponse>> GetVercelCiTaskLogsAsResponseAsync(
            string invocationId,
            string attempt,
            global::System.Collections.Generic.IList<string>? task = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsConclusionItem>? conclusion = default,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsLevelItem>? level = default,
            string? search = default,
            double? limit = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
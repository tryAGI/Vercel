#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Search the task logs of several invocation attempts<br/>
        /// Searches the task logs of up to 50 invocation attempts at once, for example the most recent runs of a branch from `GET /v2/vercel-ci/invocations`. Only invocations and tasks with matching lines are returned. When more than 1000 lines match, the newest are kept.
        /// </summary>
        /// <param name="invocation">
        /// Invocation attempts to search, as \"&lt;invocationId&gt;:&lt;attempt&gt;\" (at most 50).
        /// </param>
        /// <param name="search">
        /// Only return log lines containing this text, ignoring case.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.SearchVercelCiLogsResponse> SearchVercelCiLogsAsync(
            global::System.Collections.Generic.IList<string> invocation,
            string search,
            global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsLevelItem>? level = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search the task logs of several invocation attempts<br/>
        /// Searches the task logs of up to 50 invocation attempts at once, for example the most recent runs of a branch from `GET /v2/vercel-ci/invocations`. Only invocations and tasks with matching lines are returned. When more than 1000 lines match, the newest are kept.
        /// </summary>
        /// <param name="invocation">
        /// Invocation attempts to search, as \"&lt;invocationId&gt;:&lt;attempt&gt;\" (at most 50).
        /// </param>
        /// <param name="search">
        /// Only return log lines containing this text, ignoring case.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.SearchVercelCiLogsResponse>> SearchVercelCiLogsAsResponseAsync(
            global::System.Collections.Generic.IList<string> invocation,
            string search,
            global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsLevelItem>? level = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
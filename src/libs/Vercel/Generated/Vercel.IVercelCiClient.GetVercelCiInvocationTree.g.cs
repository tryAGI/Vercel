#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// Get an invocation with its jobs and tasks<br/>
        /// Returns an invocation attempt together with every job definition, its latest job run, and the task definitions and active task runs of that job run. Defaults to the latest attempt when `attempt` is omitted. With `follow=1` the response is a newline-delimited JSON stream: a `{"type":"tree", ...}` event with the full tree is sent immediately and again whenever it changes, and a final `{"type":"end","reason":...}` event is sent when the attempt finishes (`completed`) or the stream reaches its maximum duration (`timeout`), after which clients should reconnect.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt">
        /// Invocation attempt to return. Defaults to the latest attempt.
        /// </param>
        /// <param name="follow">
        /// When 1, stream the tree as newline-delimited JSON until the attempt finishes.
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
        global::System.Threading.Tasks.Task<global::Vercel.GetVercelCiInvocationTreeResponse> GetVercelCiInvocationTreeAsync(
            string invocationId,
            string? attempt = default,
            double? follow = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an invocation with its jobs and tasks<br/>
        /// Returns an invocation attempt together with every job definition, its latest job run, and the task definitions and active task runs of that job run. Defaults to the latest attempt when `attempt` is omitted. With `follow=1` the response is a newline-delimited JSON stream: a `{"type":"tree", ...}` event with the full tree is sent immediately and again whenever it changes, and a final `{"type":"end","reason":...}` event is sent when the attempt finishes (`completed`) or the stream reaches its maximum duration (`timeout`), after which clients should reconnect.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt">
        /// Invocation attempt to return. Defaults to the latest attempt.
        /// </param>
        /// <param name="follow">
        /// When 1, stream the tree as newline-delimited JSON until the attempt finishes.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetVercelCiInvocationTreeResponse>> GetVercelCiInvocationTreeAsResponseAsync(
            string invocationId,
            string? attempt = default,
            double? follow = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
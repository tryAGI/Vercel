#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get a project trace by request ID<br/>
        /// Returns the OTEL trace for a given Vercel CLI request.
        /// </summary>
        /// <param name="projectId">
        /// The project ID<br/>
        /// Example: prj_123
        /// </param>
        /// <param name="requestId">
        /// The Vercel CLI request ID associated with the trace<br/>
        /// Example: cli-req-abc
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
        global::System.Threading.Tasks.Task<global::Vercel.GetProjectTraceResponse> GetProjectTraceAsync(
            string projectId,
            string requestId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a project trace by request ID<br/>
        /// Returns the OTEL trace for a given Vercel CLI request.
        /// </summary>
        /// <param name="projectId">
        /// The project ID<br/>
        /// Example: prj_123
        /// </param>
        /// <param name="requestId">
        /// The Vercel CLI request ID associated with the trace<br/>
        /// Example: cli-req-abc
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetProjectTraceResponse>> GetProjectTraceAsResponseAsync(
            string projectId,
            string requestId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
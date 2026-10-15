#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Create conditional firewall bypass<br/>
        /// Create a conditional firewall bypass rule for a project domain.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConditionalBypassResponse> CreateConditionalBypassAsync(
            string projectId,

            global::Vercel.CreateConditionalBypassRequest request,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create conditional firewall bypass<br/>
        /// Create a conditional firewall bypass rule for a project domain.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateConditionalBypassResponse>> CreateConditionalBypassAsResponseAsync(
            string projectId,

            global::Vercel.CreateConditionalBypassRequest request,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create conditional firewall bypass<br/>
        /// Create a conditional firewall bypass rule for a project domain.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="domain"></param>
        /// <param name="conditionGroup"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConditionalBypassResponse> CreateConditionalBypassAsync(
            string projectId,
            string domain,
            global::System.Collections.Generic.IList<global::Vercel.CreateConditionalBypassRequestConditionGroupItem> conditionGroup,
            string? slug = default,
            string? teamId = default,
            string? note = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
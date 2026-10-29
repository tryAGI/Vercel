#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Update conditional firewall bypass<br/>
        /// Update a conditional firewall bypass rule for a project domain. Replaces conditions and the note for the domain's existing rule. Omitting `note` clears it. The rule ID, domain, creator, and creation time are preserved. Missing or deleted rules are not created.
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateConditionalBypassResponse> UpdateConditionalBypassAsync(
            string projectId,

            global::Vercel.UpdateConditionalBypassRequest request,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update conditional firewall bypass<br/>
        /// Update a conditional firewall bypass rule for a project domain. Replaces conditions and the note for the domain's existing rule. Omitting `note` clears it. The rule ID, domain, creator, and creation time are preserved. Missing or deleted rules are not created.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UpdateConditionalBypassResponse>> UpdateConditionalBypassAsResponseAsync(
            string projectId,

            global::Vercel.UpdateConditionalBypassRequest request,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update conditional firewall bypass<br/>
        /// Update a conditional firewall bypass rule for a project domain. Replaces conditions and the note for the domain's existing rule. Omitting `note` clears it. The rule ID, domain, creator, and creation time are preserved. Missing or deleted rules are not created.
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateConditionalBypassResponse> UpdateConditionalBypassAsync(
            string projectId,
            string domain,
            global::System.Collections.Generic.IList<global::Vercel.UpdateConditionalBypassRequestConditionGroupItem> conditionGroup,
            string? slug = default,
            string? teamId = default,
            string? note = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
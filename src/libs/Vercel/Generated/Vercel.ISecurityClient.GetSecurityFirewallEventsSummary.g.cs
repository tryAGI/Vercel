#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Read Firewall Actions Summary by Project<br/>
        /// Aggregate counts over the firewall actions matched by the same filters as `GET /v1/security/firewall/events`, without fetching any rows. Counts are of policies (mitigations), including ones that matched no requests.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="hosts"></param>
        /// <param name="ip"></param>
        /// <param name="isActive"></param>
        /// <param name="action"></param>
        /// <param name="actionType"></param>
        /// <param name="ruleKind"></param>
        /// <param name="ruleId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSecurityFirewallEventsSummaryResponse> GetSecurityFirewallEventsSummaryAsync(
            string projectId,
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            global::System.Collections.Generic.IList<string>? ip = default,
            bool? isActive = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsSummaryActionItem>? action = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsSummaryActionTypeItem>? actionType = default,
            global::Vercel.GetSecurityFirewallEventsSummaryRuleKind? ruleKind = default,
            global::System.Collections.Generic.IList<string>? ruleId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Firewall Actions Summary by Project<br/>
        /// Aggregate counts over the firewall actions matched by the same filters as `GET /v1/security/firewall/events`, without fetching any rows. Counts are of policies (mitigations), including ones that matched no requests.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="hosts"></param>
        /// <param name="ip"></param>
        /// <param name="isActive"></param>
        /// <param name="action"></param>
        /// <param name="actionType"></param>
        /// <param name="ruleKind"></param>
        /// <param name="ruleId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetSecurityFirewallEventsSummaryResponse>> GetSecurityFirewallEventsSummaryAsResponseAsync(
            string projectId,
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            global::System.Collections.Generic.IList<string>? ip = default,
            bool? isActive = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsSummaryActionItem>? action = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsSummaryActionTypeItem>? actionType = default,
            global::Vercel.GetSecurityFirewallEventsSummaryRuleKind? ruleKind = default,
            global::System.Collections.Generic.IList<string>? ruleId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
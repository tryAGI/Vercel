#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Read Firewall Actions by Project<br/>
        /// Retrieve firewall actions for a project Rule names are resolved against the project's *current* active firewall configuration and the team's active rulesets, so a rule that has since been renamed reports its new name and one that has been deleted reports `null`. System rules such as `sys_dos_mitigation` and `ip_blocking` have no configured name and always report `null`. Filters (`ip`, `isActive`, `action`, `actionType`, `ruleKind`, `ruleId`, `hosts`) are ANDed across params and ORed within a repeated param. They are applied to the policies before `limit`/`cursor`, so pages only count matching policies. A policy with no matching requests yields no action row, so a page can hold fewer than `limit` actions; only `pagination.next` signals the end. A `cursor` is only valid with the filters it was issued for.
        /// </summary>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.GetSecurityFirewallEventsResponse> GetSecurityFirewallEventsAsync(
            string projectId,
            global::Vercel.GetSecurityFirewallEventsSort? sort = default,
            double? limit = default,
            string? cursor = default,
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            global::System.Collections.Generic.IList<string>? ip = default,
            bool? isActive = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsActionItem>? action = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsActionTypeItem>? actionType = default,
            global::Vercel.GetSecurityFirewallEventsRuleKind? ruleKind = default,
            global::System.Collections.Generic.IList<string>? ruleId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Firewall Actions by Project<br/>
        /// Retrieve firewall actions for a project Rule names are resolved against the project's *current* active firewall configuration and the team's active rulesets, so a rule that has since been renamed reports its new name and one that has been deleted reports `null`. System rules such as `sys_dos_mitigation` and `ip_blocking` have no configured name and always report `null`. Filters (`ip`, `isActive`, `action`, `actionType`, `ruleKind`, `ruleId`, `hosts`) are ANDed across params and ORed within a repeated param. They are applied to the policies before `limit`/`cursor`, so pages only count matching policies. A policy with no matching requests yields no action row, so a page can hold fewer than `limit` actions; only `pagination.next` signals the end. A `cursor` is only valid with the filters it was issued for.
        /// </summary>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetSecurityFirewallEventsResponse>> GetSecurityFirewallEventsAsResponseAsync(
            string projectId,
            global::Vercel.GetSecurityFirewallEventsSort? sort = default,
            double? limit = default,
            string? cursor = default,
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            global::System.Collections.Generic.IList<string>? ip = default,
            bool? isActive = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsActionItem>? action = default,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallEventsActionTypeItem>? actionType = default,
            global::Vercel.GetSecurityFirewallEventsRuleKind? ruleKind = default,
            global::System.Collections.Generic.IList<string>? ruleId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
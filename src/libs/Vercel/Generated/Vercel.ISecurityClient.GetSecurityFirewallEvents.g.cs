#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Read Firewall Actions by Project<br/>
        /// Retrieve firewall actions for a project Rule names are resolved against the project's *current* active firewall configuration and the team's active rulesets, so a rule that has since been renamed reports its new name and one that has been deleted reports `null`. System rules such as `sys_dos_mitigation` and `ip_blocking` have no configured name and always report `null`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="hosts"></param>
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
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Firewall Actions by Project<br/>
        /// Retrieve firewall actions for a project Rule names are resolved against the project's *current* active firewall configuration and the team's active rulesets, so a rule that has since been renamed reports its new name and one that has been deleted reports `null`. System rules such as `sys_dos_mitigation` and `ip_blocking` have no configured name and always report `null`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="hosts"></param>
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
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
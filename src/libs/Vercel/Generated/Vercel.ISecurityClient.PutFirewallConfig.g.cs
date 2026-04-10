#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Put Firewall Configuration<br/>
        /// Set the firewall configuration to provided rules and settings. Creates or overwrite the existing firewall configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.PutFirewallConfigResponse> PutFirewallConfigAsync(
            string projectId,

            global::Vercel.PutFirewallConfigRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Firewall Configuration<br/>
        /// Set the firewall configuration to provided rules and settings. Creates or overwrite the existing firewall configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="firewallEnabled"></param>
        /// <param name="managedRules"></param>
        /// <param name="crs">
        /// Custom Ruleset
        /// </param>
        /// <param name="rules"></param>
        /// <param name="ips"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="logHeaders"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.PutFirewallConfigResponse> PutFirewallConfigAsync(
            string projectId,
            bool firewallEnabled,
            string? teamId = default,
            string? slug = default,
            object? managedRules = default,
            global::Vercel.PutFirewallConfigRequestCrs? crs = default,
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRule>? rules = default,
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestIp>? ips = default,
            bool? botIdEnabled = default,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? logHeaders = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
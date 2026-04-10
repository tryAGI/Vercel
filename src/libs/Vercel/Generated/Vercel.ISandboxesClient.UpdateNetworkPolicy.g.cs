#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update network policy<br/>
        /// Replaces the network access policy of a running sandbox. Use this to control which external hosts the sandbox can communicate with. This is a full replacement. Any previously configured network rules will be overwritten.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to update the network policy for.<br/>
        /// Example: sbx_abc123
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateNetworkPolicyResponse> UpdateNetworkPolicyAsync(
            string sandboxId,

            global::Vercel.UpdateNetworkPolicyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update network policy<br/>
        /// Replaces the network access policy of a running sandbox. Use this to control which external hosts the sandbox can communicate with. This is a full replacement. Any previously configured network rules will be overwritten.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to update the network policy for.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="mode">
        /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
        /// Example: custom
        /// </param>
        /// <param name="allowedDomains">
        /// List of domain names the sandbox is allowed to connect to. Only applies when mode is \"custom\". Supports wildcard patterns (e.g., \"*.example.com\" matches all subdomains).<br/>
        /// Example: [api.github.com, *.npmjs.org]
        /// </param>
        /// <param name="allowedCIDRs">
        /// List of IP address ranges (in CIDR notation) the sandbox is allowed to connect to. Traffic to these addresses bypasses domain-based restrictions.<br/>
        /// Example: [35.192.0.0/12, 104.16.0.0/12]
        /// </param>
        /// <param name="deniedCIDRs">
        /// List of IP address ranges (in CIDR notation) the sandbox is blocked from connecting to. These rules take precedence over all allowed rules.<br/>
        /// Example: [35.192.0.0/12]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateNetworkPolicyResponse> UpdateNetworkPolicyAsync(
            string sandboxId,
            global::Vercel.UpdateNetworkPolicyRequestMode mode,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? allowedDomains = default,
            global::System.Collections.Generic.IList<string>? allowedCIDRs = default,
            global::System.Collections.Generic.IList<string>? deniedCIDRs = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
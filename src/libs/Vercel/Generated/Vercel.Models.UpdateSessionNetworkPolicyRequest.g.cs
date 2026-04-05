
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
    /// </summary>
    public sealed partial class UpdateSessionNetworkPolicyRequest
    {
        /// <summary>
        /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
        /// Example: custom
        /// </summary>
        /// <example>custom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateSessionNetworkPolicyRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateSessionNetworkPolicyRequestMode Mode { get; set; }

        /// <summary>
        /// List of domain names the sandbox is allowed to connect to. Only applies when mode is \"custom\". Supports wildcard patterns (e.g., \"*.example.com\" matches all subdomains).<br/>
        /// Example: [api.github.com, *.npmjs.org]
        /// </summary>
        /// <example>[api.github.com, *.npmjs.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedDomains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// List of IP address ranges (in CIDR notation) the sandbox is allowed to connect to. Traffic to these addresses bypasses domain-based restrictions.<br/>
        /// Example: [35.192.0.0/12, 104.16.0.0/12]
        /// </summary>
        /// <example>[35.192.0.0/12, 104.16.0.0/12]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCIDRs")]
        public global::System.Collections.Generic.IList<string>? AllowedCIDRs { get; set; }

        /// <summary>
        /// List of IP address ranges (in CIDR notation) the sandbox is blocked from connecting to. These rules take precedence over all allowed rules.<br/>
        /// Example: [35.192.0.0/12]
        /// </summary>
        /// <example>[35.192.0.0/12]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deniedCIDRs")]
        public global::System.Collections.Generic.IList<string>? DeniedCIDRs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionNetworkPolicyRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSessionNetworkPolicyRequest(
            global::Vercel.UpdateSessionNetworkPolicyRequestMode mode,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? allowedCIDRs,
            global::System.Collections.Generic.IList<string>? deniedCIDRs)
        {
            this.Mode = mode;
            this.AllowedDomains = allowedDomains;
            this.AllowedCIDRs = allowedCIDRs;
            this.DeniedCIDRs = deniedCIDRs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionNetworkPolicyRequest" /> class.
        /// </summary>
        public UpdateSessionNetworkPolicyRequest()
        {
        }
    }
}
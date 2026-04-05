
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network policy applied to this sandbox, if any.
    /// </summary>
    public sealed partial class SandboxNetworkPolicy
    {
        /// <summary>
        /// The network policy mode. - 'allow-all': All traffic is allowed. - 'deny-all': All traffic is blocked. - 'custom': Traffic is controlled by explicit allow/deny rules.<br/>
        /// Example: custom
        /// </summary>
        /// <example>custom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SandboxNetworkPolicyModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SandboxNetworkPolicyMode Mode { get; set; }

        /// <summary>
        /// List of domain names the sandbox is allowed to connect to. Supports wildcard patterns (e.g., "*.vercel.com" matches all subdomains).<br/>
        /// Example: [api.vercel.com, *.example.com]
        /// </summary>
        /// <example>[api.vercel.com, *.example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedDomains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// List of IP address ranges (in CIDR notation) the sandbox is allowed to connect to.<br/>
        /// Example: [10.0.0.0/8]
        /// </summary>
        /// <example>[10.0.0.0/8]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCIDRs")]
        public global::System.Collections.Generic.IList<string>? AllowedCIDRs { get; set; }

        /// <summary>
        /// List of IP address ranges (in CIDR notation) the sandbox is blocked from connecting to. These rules take precedence over all allowed rules.<br/>
        /// Example: [10.0.0.0/8]
        /// </summary>
        /// <example>[10.0.0.0/8]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deniedCIDRs")]
        public global::System.Collections.Generic.IList<string>? DeniedCIDRs { get; set; }

        /// <summary>
        /// HTTP header injection rules for outgoing requests matching specific domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injectionRules")]
        public global::System.Collections.Generic.IList<global::Vercel.SandboxInjectionRule>? InjectionRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkPolicy" /> class.
        /// </summary>
        /// <param name="mode">
        /// The network policy mode. - 'allow-all': All traffic is allowed. - 'deny-all': All traffic is blocked. - 'custom': Traffic is controlled by explicit allow/deny rules.<br/>
        /// Example: custom
        /// </param>
        /// <param name="allowedDomains">
        /// List of domain names the sandbox is allowed to connect to. Supports wildcard patterns (e.g., "*.vercel.com" matches all subdomains).<br/>
        /// Example: [api.vercel.com, *.example.com]
        /// </param>
        /// <param name="allowedCIDRs">
        /// List of IP address ranges (in CIDR notation) the sandbox is allowed to connect to.<br/>
        /// Example: [10.0.0.0/8]
        /// </param>
        /// <param name="deniedCIDRs">
        /// List of IP address ranges (in CIDR notation) the sandbox is blocked from connecting to. These rules take precedence over all allowed rules.<br/>
        /// Example: [10.0.0.0/8]
        /// </param>
        /// <param name="injectionRules">
        /// HTTP header injection rules for outgoing requests matching specific domains.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxNetworkPolicy(
            global::Vercel.SandboxNetworkPolicyMode mode,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? allowedCIDRs,
            global::System.Collections.Generic.IList<string>? deniedCIDRs,
            global::System.Collections.Generic.IList<global::Vercel.SandboxInjectionRule>? injectionRules)
        {
            this.Mode = mode;
            this.AllowedDomains = allowedDomains;
            this.AllowedCIDRs = allowedCIDRs;
            this.DeniedCIDRs = deniedCIDRs;
            this.InjectionRules = injectionRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkPolicy" /> class.
        /// </summary>
        public SandboxNetworkPolicy()
        {
        }
    }
}
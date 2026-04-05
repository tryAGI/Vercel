
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Network policy configuration.
    /// </summary>
    public sealed partial class NamedSandboxNetworkPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.NamedSandboxNetworkPolicyModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.NamedSandboxNetworkPolicyMode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedDomains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCIDRs")]
        public global::System.Collections.Generic.IList<string>? AllowedCIDRs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deniedCIDRs")]
        public global::System.Collections.Generic.IList<string>? DeniedCIDRs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandboxNetworkPolicy" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="allowedCIDRs"></param>
        /// <param name="deniedCIDRs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedSandboxNetworkPolicy(
            global::Vercel.NamedSandboxNetworkPolicyMode mode,
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
        /// Initializes a new instance of the <see cref="NamedSandboxNetworkPolicy" /> class.
        /// </summary>
        public NamedSandboxNetworkPolicy()
        {
        }
    }
}
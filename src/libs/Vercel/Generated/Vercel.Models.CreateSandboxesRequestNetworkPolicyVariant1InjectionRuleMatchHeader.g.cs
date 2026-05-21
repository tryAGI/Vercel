
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeader
    {
        /// <summary>
        /// Matcher for the entry key (header name or query key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeaderKey? Key { get; set; }

        /// <summary>
        /// Matcher for the entry value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeaderValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeader" /> class.
        /// </summary>
        /// <param name="key">
        /// Matcher for the entry key (header name or query key).
        /// </param>
        /// <param name="value">
        /// Matcher for the entry value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeader(
            global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeaderKey? key,
            global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeaderValue? value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeader" /> class.
        /// </summary>
        public CreateSandboxesRequestNetworkPolicyVariant1InjectionRuleMatchHeader()
        {
        }

    }
}
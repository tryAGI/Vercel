
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem
    {
        /// <summary>
        /// Matcher for the entry key (header name or query key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Vercel.CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItemKey? Key { get; set; }

        /// <summary>
        /// Matcher for the entry value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Vercel.CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItemValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem" /> class.
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
        public CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem(
            global::Vercel.CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItemKey? key,
            global::Vercel.CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItemValue? value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem" /> class.
        /// </summary>
        public CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem()
        {
        }

    }
}
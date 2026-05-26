
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItem
    {
        /// <summary>
        /// Matcher for the entry key (header name or query key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemKey? Key { get; set; }

        /// <summary>
        /// Matcher for the entry value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItem" /> class.
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
        public CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItem(
            global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemKey? key,
            global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue? value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItem" /> class.
        /// </summary>
        public CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItem()
        {
        }

    }
}
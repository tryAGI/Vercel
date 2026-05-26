
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Matcher for the entry value.
    /// </summary>
    public sealed partial class CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue
    {
        /// <summary>
        /// Match the value exactly. Case-sensitive for paths, header values, and methods; case-insensitive for domains and header keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exact")]
        public string? Exact { get; set; }

        /// <summary>
        /// Match values that start with the given prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startsWith")]
        public string? StartsWith { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue" /> class.
        /// </summary>
        /// <param name="exact">
        /// Match the value exactly. Case-sensitive for paths, header values, and methods; case-insensitive for domains and header keys.
        /// </param>
        /// <param name="startsWith">
        /// Match values that start with the given prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue(
            string? exact,
            string? startsWith)
        {
            this.Exact = exact;
            this.StartsWith = startsWith;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue" /> class.
        /// </summary>
        public CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItemMatchQueryStringItemValue()
        {
        }

    }
}
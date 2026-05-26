
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItem>>>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItem>>>? Allow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subnets")]
        public global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2Subnets? Subnets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2" /> class.
        /// </summary>
        /// <param name="allow"></param>
        /// <param name="subnets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2(
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2AllowItem>>>? allow,
            global::Vercel.CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2Subnets? subnets)
        {
            this.Allow = allow;
            this.Subnets = subnets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2" /> class.
        /// </summary>
        public CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant2()
        {
        }

    }
}
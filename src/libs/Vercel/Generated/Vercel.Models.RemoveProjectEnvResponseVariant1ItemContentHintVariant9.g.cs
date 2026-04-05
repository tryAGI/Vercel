
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveProjectEnvResponseVariant1ItemContentHintVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RemoveProjectEnvResponseVariant1ItemContentHintVariant9TypeJsonConverter))]
        public global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProjectEnvResponseVariant1ItemContentHintVariant9" /> class.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveProjectEnvResponseVariant1ItemContentHintVariant9(
            string storeId,
            global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant9Type type)
        {
            this.Type = type;
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProjectEnvResponseVariant1ItemContentHintVariant9" /> class.
        /// </summary>
        public RemoveProjectEnvResponseVariant1ItemContentHintVariant9()
        {
        }
    }
}
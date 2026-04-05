
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterProjectEnvsResponseVariant3EnvContentHintVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FilterProjectEnvsResponseVariant3EnvContentHintVariant1TypeJsonConverter))]
        public global::Vercel.FilterProjectEnvsResponseVariant3EnvContentHintVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="FilterProjectEnvsResponseVariant3EnvContentHintVariant1" /> class.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterProjectEnvsResponseVariant3EnvContentHintVariant1(
            string storeId,
            global::Vercel.FilterProjectEnvsResponseVariant3EnvContentHintVariant1Type type)
        {
            this.Type = type;
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterProjectEnvsResponseVariant3EnvContentHintVariant1" /> class.
        /// </summary>
        public FilterProjectEnvsResponseVariant3EnvContentHintVariant1()
        {
        }
    }
}
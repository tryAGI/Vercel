
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaTypeJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="type"></param>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchema(
            object properties,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaType type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchema" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchema()
        {
        }
    }
}
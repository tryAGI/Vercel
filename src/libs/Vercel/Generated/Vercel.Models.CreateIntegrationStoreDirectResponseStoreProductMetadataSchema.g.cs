
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductMetadataSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaTypeJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="type"></param>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchema(
            object properties,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaType type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchema" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchema()
        {
        }
    }
}
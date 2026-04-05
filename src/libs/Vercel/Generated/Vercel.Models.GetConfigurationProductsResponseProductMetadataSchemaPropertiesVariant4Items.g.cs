
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4Items
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4ItemsTypeJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4ItemsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMinimum")]
        public double? ExclusiveMinimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMaximum")]
        public double? ExclusiveMaximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4Items" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="minimum"></param>
        /// <param name="exclusiveMinimum"></param>
        /// <param name="maximum"></param>
        /// <param name="exclusiveMaximum"></param>
        /// <param name="default"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4Items(
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4ItemsType type,
            string? description,
            double? minimum,
            double? exclusiveMinimum,
            double? maximum,
            double? exclusiveMaximum,
            double? @default)
        {
            this.Type = type;
            this.Description = description;
            this.Minimum = minimum;
            this.ExclusiveMinimum = exclusiveMinimum;
            this.Maximum = maximum;
            this.ExclusiveMaximum = exclusiveMaximum;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4Items" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant4Items()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum2?>? Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3HiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3HiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3HiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3HiddenEnum2?>? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
        /// <param name="hidden"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3(
            string value,
            string? description,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum2?>? disabled,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3HiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3HiddenEnum2?>? hidden)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Description = description;
            this.Disabled = disabled;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3TypeJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiControlJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiControl Ui_control { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:paid-only")]
        public bool? Ui_paidOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="description"></param>
        /// <param name="default"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_readOnly"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="ui_paidOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3(
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3Type type,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiControl ui_control,
            string? description,
            bool? @default,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiDescription>? ui_description,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3UiFormattedValue? ui_formattedValue,
            bool? ui_paidOnly)
        {
            this.Type = type;
            this.Ui_control = ui_control;
            this.Description = description;
            this.Default = @default;
            this.Ui_label = ui_label;
            this.Ui_readOnly = ui_readOnly;
            this.Ui_hidden = ui_hidden;
            this.Ui_disabled = ui_disabled;
            this.Ui_description = ui_description;
            this.Ui_formattedValue = ui_formattedValue;
            this.Ui_paidOnly = ui_paidOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant3()
        {
        }
    }
}
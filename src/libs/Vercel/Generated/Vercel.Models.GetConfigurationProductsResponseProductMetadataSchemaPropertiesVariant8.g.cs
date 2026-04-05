
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8TypeJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControlJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl Ui_control { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant1, string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3>> Ui_options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLength")]
        public double? MaxLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minLength")]
        public double? MinLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:placeholder")]
        public string? Ui_placeholder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8" /> class.
        /// </summary>
        /// <param name="ui_options"></param>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="description"></param>
        /// <param name="enum"></param>
        /// <param name="maxLength"></param>
        /// <param name="minLength"></param>
        /// <param name="pattern"></param>
        /// <param name="default"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_readOnly"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="ui_placeholder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8(
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant1, string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiOptionVariant3>> ui_options,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8Type type,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl ui_control,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            double? maxLength,
            double? minLength,
            string? pattern,
            string? @default,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiDescription>? ui_description,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiFormattedValue? ui_formattedValue,
            string? ui_placeholder)
        {
            this.Type = type;
            this.Ui_control = ui_control;
            this.Ui_options = ui_options ?? throw new global::System.ArgumentNullException(nameof(ui_options));
            this.Description = description;
            this.Enum = @enum;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.Pattern = pattern;
            this.Default = @default;
            this.Ui_label = ui_label;
            this.Ui_readOnly = ui_readOnly;
            this.Ui_hidden = ui_hidden;
            this.Ui_disabled = ui_disabled;
            this.Ui_description = ui_description;
            this.Ui_formattedValue = ui_formattedValue;
            this.Ui_placeholder = ui_placeholder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8()
        {
        }
    }
}
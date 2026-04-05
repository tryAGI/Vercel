
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9TypeJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9Items Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControlJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl Ui_control { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiOptionVariant1, string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiOptionVariant3>> Ui_options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxItems")]
        public double? MaxItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minItems")]
        public double? MinItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:placeholder")]
        public string? Ui_placeholder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::System.Collections.Generic.IList<string>? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example")]
        public global::System.Collections.Generic.IList<string>? Example { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ui_options"></param>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="description"></param>
        /// <param name="maxItems"></param>
        /// <param name="minItems"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_readOnly"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="ui_placeholder"></param>
        /// <param name="default"></param>
        /// <param name="example"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9(
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9Items items,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiOptionVariant1, string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiOptionVariant3>> ui_options,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9Type type,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl ui_control,
            string? description,
            double? maxItems,
            double? minItems,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiDescription>? ui_description,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiFormattedValue? ui_formattedValue,
            string? ui_placeholder,
            global::System.Collections.Generic.IList<string>? @default,
            global::System.Collections.Generic.IList<string>? example)
        {
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Ui_control = ui_control;
            this.Ui_options = ui_options ?? throw new global::System.ArgumentNullException(nameof(ui_options));
            this.Description = description;
            this.MaxItems = maxItems;
            this.MinItems = minItems;
            this.Ui_label = ui_label;
            this.Ui_readOnly = ui_readOnly;
            this.Ui_hidden = ui_hidden;
            this.Ui_disabled = ui_disabled;
            this.Ui_description = ui_description;
            this.Ui_formattedValue = ui_formattedValue;
            this.Ui_placeholder = ui_placeholder;
            this.Default = @default;
            this.Example = example;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9()
        {
        }
    }
}
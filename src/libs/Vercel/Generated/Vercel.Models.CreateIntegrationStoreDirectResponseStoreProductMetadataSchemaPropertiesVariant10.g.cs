
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10TypeJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiControlJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiControl Ui_control { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiFormattedValue? Ui_formattedValue { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="enum"></param>
        /// <param name="maxLength"></param>
        /// <param name="minLength"></param>
        /// <param name="pattern"></param>
        /// <param name="description"></param>
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
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10Type type,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiControl ui_control,
            global::System.Collections.Generic.IList<string>? @enum,
            double? maxLength,
            double? minLength,
            string? pattern,
            string? description,
            string? @default,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiDescription>? ui_description,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiFormattedValue? ui_formattedValue,
            string? ui_placeholder)
        {
            this.Type = type;
            this.Ui_control = ui_control;
            this.Enum = @enum;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.Pattern = pattern;
            this.Description = description;
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
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10()
        {
        }
    }
}
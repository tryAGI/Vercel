
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2TypeJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiControlJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiControl Ui_control { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiFormattedValue? Ui_formattedValue { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="maximum"></param>
        /// <param name="exclusiveMaximum"></param>
        /// <param name="minimum"></param>
        /// <param name="exclusiveMinimum"></param>
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
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type type,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiControl ui_control,
            double? maximum,
            double? exclusiveMaximum,
            double? minimum,
            double? exclusiveMinimum,
            string? description,
            double? @default,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiDescription>? ui_description,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiFormattedValue? ui_formattedValue,
            string? ui_placeholder)
        {
            this.Type = type;
            this.Ui_control = ui_control;
            this.Maximum = maximum;
            this.ExclusiveMaximum = exclusiveMaximum;
            this.Minimum = minimum;
            this.ExclusiveMinimum = exclusiveMinimum;
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
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2()
        {
        }
    }
}
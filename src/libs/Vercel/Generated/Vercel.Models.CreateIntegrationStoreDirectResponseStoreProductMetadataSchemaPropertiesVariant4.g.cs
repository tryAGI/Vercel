
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4TypeJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4Items Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiControlJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiControl Ui_control { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Ui_steps { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::System.Collections.Generic.IList<double>? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ui_steps"></param>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="maxItems"></param>
        /// <param name="minItems"></param>
        /// <param name="description"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_readOnly"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="default"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4Items items,
            global::System.Collections.Generic.IList<double> ui_steps,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4Type type,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiControl ui_control,
            double? maxItems,
            double? minItems,
            string? description,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiReadOnlyEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiHiddenEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDisabledEnum, bool?, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiDescription>? ui_description,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4UiFormattedValue? ui_formattedValue,
            global::System.Collections.Generic.IList<double>? @default)
        {
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Ui_control = ui_control;
            this.Ui_steps = ui_steps ?? throw new global::System.ArgumentNullException(nameof(ui_steps));
            this.MaxItems = maxItems;
            this.MinItems = minItems;
            this.Description = description;
            this.Ui_label = ui_label;
            this.Ui_readOnly = ui_readOnly;
            this.Ui_hidden = ui_hidden;
            this.Ui_disabled = ui_disabled;
            this.Ui_description = ui_description;
            this.Ui_formattedValue = ui_formattedValue;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant4()
        {
        }
    }
}
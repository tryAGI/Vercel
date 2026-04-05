
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11TypeJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiControlJsonConverter))]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiControl Ui_control { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDescription>? Ui_description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:placeholder")]
        public string? Ui_placeholder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git:providers")]
        public global::System.Collections.Generic.IList<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider>? Git_providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="description"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_readOnly"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="ui_placeholder"></param>
        /// <param name="git_providers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11(
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11Type type,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiControl ui_control,
            string? description,
            string? ui_label,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiReadOnlyEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiReadOnlyEnum2?>? ui_readOnly,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiHiddenEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiHiddenEnum2?>? ui_hidden,
            global::Vercel.OneOf<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDisabledEnum, bool?, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDisabledEnum2?>? ui_disabled,
            global::Vercel.OneOf<string, global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiDescription>? ui_description,
            global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11UiFormattedValue? ui_formattedValue,
            string? ui_placeholder,
            global::System.Collections.Generic.IList<global::Vercel.GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider>? git_providers)
        {
            this.Type = type;
            this.Ui_control = ui_control;
            this.Description = description;
            this.Ui_label = ui_label;
            this.Ui_readOnly = ui_readOnly;
            this.Ui_hidden = ui_hidden;
            this.Ui_disabled = ui_disabled;
            this.Ui_description = ui_description;
            this.Ui_formattedValue = ui_formattedValue;
            this.Ui_placeholder = ui_placeholder;
            this.Git_providers = git_providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11()
        {
        }
    }
}
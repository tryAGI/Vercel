
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedceccd47983fcf9deVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::System.Collections.Generic.IList<double>? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4Items Items { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant4TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant4UiControlJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiControl Ui_control { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDescription>? Ui_description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:paid-only")]
        public bool? Ui_paidOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Ui_steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant4" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ui_steps"></param>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="maxItems"></param>
        /// <param name="minItems"></param>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_paidOnly"></param>
        /// <param name="ui_readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedceccd47983fcf9deVariant4(
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4Items items,
            global::System.Collections.Generic.IList<double> ui_steps,
            global::System.Collections.Generic.IList<double>? @default,
            string? description,
            double? maxItems,
            double? minItems,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4Type type,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiControl ui_control,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDescription>? ui_description,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiDisabledEnum2?>? ui_disabled,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiFormattedValue? ui_formattedValue,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiHiddenEnum2?>? ui_hidden,
            string? ui_label,
            bool? ui_paidOnly,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4UiReadOnlyEnum2?>? ui_readOnly)
        {
            this.Default = @default;
            this.Description = description;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.MaxItems = maxItems;
            this.MinItems = minItems;
            this.Type = type;
            this.Ui_control = ui_control;
            this.Ui_description = ui_description;
            this.Ui_disabled = ui_disabled;
            this.Ui_formattedValue = ui_formattedValue;
            this.Ui_hidden = ui_hidden;
            this.Ui_label = ui_label;
            this.Ui_paidOnly = ui_paidOnly;
            this.Ui_readOnly = ui_readOnly;
            this.Ui_steps = ui_steps ?? throw new global::System.ArgumentNullException(nameof(ui_steps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant4" /> class.
        /// </summary>
        public AutoSDKSharedceccd47983fcf9deVariant4()
        {
        }

    }
}
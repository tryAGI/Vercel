
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedceccd47983fcf9deVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMaximum")]
        public double? ExclusiveMaximum { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant2UiControlJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiControl Ui_control { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDescription>? Ui_description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiHiddenEnum2?>? Ui_hidden { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:placeholder")]
        public string? Ui_placeholder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:read-only")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant2" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="exclusiveMaximum"></param>
        /// <param name="exclusiveMinimum"></param>
        /// <param name="maximum"></param>
        /// <param name="minimum"></param>
        /// <param name="type"></param>
        /// <param name="ui_control"></param>
        /// <param name="ui_description"></param>
        /// <param name="ui_disabled"></param>
        /// <param name="ui_formattedValue"></param>
        /// <param name="ui_hidden"></param>
        /// <param name="ui_label"></param>
        /// <param name="ui_paidOnly"></param>
        /// <param name="ui_placeholder"></param>
        /// <param name="ui_readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedceccd47983fcf9deVariant2(
            double? @default,
            string? description,
            double? exclusiveMaximum,
            double? exclusiveMinimum,
            double? maximum,
            double? minimum,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2Type type,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiControl ui_control,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDescription>? ui_description,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiDisabledEnum2?>? ui_disabled,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiFormattedValue? ui_formattedValue,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiHiddenEnum2?>? ui_hidden,
            string? ui_label,
            bool? ui_paidOnly,
            string? ui_placeholder,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2UiReadOnlyEnum2?>? ui_readOnly)
        {
            this.Default = @default;
            this.Description = description;
            this.ExclusiveMaximum = exclusiveMaximum;
            this.ExclusiveMinimum = exclusiveMinimum;
            this.Maximum = maximum;
            this.Minimum = minimum;
            this.Type = type;
            this.Ui_control = ui_control;
            this.Ui_description = ui_description;
            this.Ui_disabled = ui_disabled;
            this.Ui_formattedValue = ui_formattedValue;
            this.Ui_hidden = ui_hidden;
            this.Ui_label = ui_label;
            this.Ui_paidOnly = ui_paidOnly;
            this.Ui_placeholder = ui_placeholder;
            this.Ui_readOnly = ui_readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant2" /> class.
        /// </summary>
        public AutoSDKSharedceccd47983fcf9deVariant2()
        {
        }

    }
}
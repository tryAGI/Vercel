
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedceccd47983fcf9deVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant1UiControlJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiControl Ui_control { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDescription>? Ui_description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiHiddenEnum2?>? Ui_hidden { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant1" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="enum"></param>
        /// <param name="maxLength"></param>
        /// <param name="minLength"></param>
        /// <param name="pattern"></param>
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
        public AutoSDKSharedceccd47983fcf9deVariant1(
            string? @default,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            double? maxLength,
            double? minLength,
            string? pattern,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1Type type,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiControl ui_control,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDescription>? ui_description,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiDisabledEnum2?>? ui_disabled,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiFormattedValue? ui_formattedValue,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiHiddenEnum2?>? ui_hidden,
            string? ui_label,
            bool? ui_paidOnly,
            string? ui_placeholder,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1UiReadOnlyEnum2?>? ui_readOnly)
        {
            this.Default = @default;
            this.Description = description;
            this.Enum = @enum;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.Pattern = pattern;
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant1" /> class.
        /// </summary>
        public AutoSDKSharedceccd47983fcf9deVariant1()
        {
        }

    }
}
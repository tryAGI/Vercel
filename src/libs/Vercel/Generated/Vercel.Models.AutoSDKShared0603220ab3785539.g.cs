
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0603220ab3785539
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0603220ab3785539TypeJsonConverter))]
        public global::Vercel.AutoSDKShared0603220ab3785539Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0603220ab3785539UiControlJsonConverter))]
        public global::Vercel.AutoSDKShared0603220ab3785539UiControl Ui_control { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared0603220ab3785539UiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKShared0603220ab3785539UiDescription>? Ui_description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0603220ab3785539UiDisabledEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiDisabledEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.AutoSDKShared0603220ab3785539UiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0603220ab3785539UiHiddenEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiHiddenEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiHiddenEnum2?>? Ui_hidden { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:label")]
        public string? Ui_label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1, string, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant3>> Ui_options { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0603220ab3785539UiReadOnlyEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiReadOnlyEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0603220ab3785539" /> class.
        /// </summary>
        /// <param name="ui_options"></param>
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
        public AutoSDKShared0603220ab3785539(
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1, string, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant3>> ui_options,
            string? @default,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            double? maxLength,
            double? minLength,
            string? pattern,
            global::Vercel.AutoSDKShared0603220ab3785539Type type,
            global::Vercel.AutoSDKShared0603220ab3785539UiControl ui_control,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared0603220ab3785539UiDescription>? ui_description,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiDisabledEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiDisabledEnum2?>? ui_disabled,
            global::Vercel.AutoSDKShared0603220ab3785539UiFormattedValue? ui_formattedValue,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiHiddenEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiHiddenEnum2?>? ui_hidden,
            string? ui_label,
            bool? ui_paidOnly,
            string? ui_placeholder,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiReadOnlyEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiReadOnlyEnum2?>? ui_readOnly)
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
            this.Ui_options = ui_options ?? throw new global::System.ArgumentNullException(nameof(ui_options));
            this.Ui_paidOnly = ui_paidOnly;
            this.Ui_placeholder = ui_placeholder;
            this.Ui_readOnly = ui_readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0603220ab3785539" /> class.
        /// </summary>
        public AutoSDKShared0603220ab3785539()
        {
        }

    }
}
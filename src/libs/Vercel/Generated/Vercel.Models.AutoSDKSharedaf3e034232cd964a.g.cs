
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedaf3e034232cd964a
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::System.Collections.Generic.IList<string>? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example")]
        public global::System.Collections.Generic.IList<string>? Example { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedaf3e034232cd964aItems Items { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedaf3e034232cd964aTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedaf3e034232cd964aType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedaf3e034232cd964aUiControlJsonConverter))]
        public global::Vercel.AutoSDKSharedaf3e034232cd964aUiControl Ui_control { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedaf3e034232cd964aUiDescription>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedaf3e034232cd964aUiDescription>? Ui_description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedaf3e034232cd964aUiDisabledEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedaf3e034232cd964aUiDisabledEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiDisabledEnum2?>? Ui_disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:formatted-value")]
        public global::Vercel.AutoSDKSharedaf3e034232cd964aUiFormattedValue? Ui_formattedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedaf3e034232cd964aUiHiddenEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedaf3e034232cd964aUiHiddenEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiHiddenEnum2?>? Ui_hidden { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedaf3e034232cd964aUiOption> Ui_options { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedaf3e034232cd964aUiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiReadOnlyEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedaf3e034232cd964aUiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiReadOnlyEnum2?>? Ui_readOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedaf3e034232cd964a" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ui_options"></param>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="example"></param>
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
        /// <param name="ui_placeholder"></param>
        /// <param name="ui_readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedaf3e034232cd964a(
            global::Vercel.AutoSDKSharedaf3e034232cd964aItems items,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedaf3e034232cd964aUiOption> ui_options,
            global::System.Collections.Generic.IList<string>? @default,
            string? description,
            global::System.Collections.Generic.IList<string>? example,
            double? maxItems,
            double? minItems,
            global::Vercel.AutoSDKSharedaf3e034232cd964aType type,
            global::Vercel.AutoSDKSharedaf3e034232cd964aUiControl ui_control,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedaf3e034232cd964aUiDescription>? ui_description,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedaf3e034232cd964aUiDisabledEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiDisabledEnum2?>? ui_disabled,
            global::Vercel.AutoSDKSharedaf3e034232cd964aUiFormattedValue? ui_formattedValue,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedaf3e034232cd964aUiHiddenEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiHiddenEnum2?>? ui_hidden,
            string? ui_label,
            bool? ui_paidOnly,
            string? ui_placeholder,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedaf3e034232cd964aUiReadOnlyEnum, bool?, global::Vercel.AutoSDKSharedaf3e034232cd964aUiReadOnlyEnum2?>? ui_readOnly)
        {
            this.Default = @default;
            this.Description = description;
            this.Example = example;
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
            this.Ui_options = ui_options ?? throw new global::System.ArgumentNullException(nameof(ui_options));
            this.Ui_paidOnly = ui_paidOnly;
            this.Ui_placeholder = ui_placeholder;
            this.Ui_readOnly = ui_readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedaf3e034232cd964a" /> class.
        /// </summary>
        public AutoSDKSharedaf3e034232cd964a()
        {
        }

    }
}
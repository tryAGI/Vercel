
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0603220ab3785539UiOptionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1DisabledEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1DisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1DisabledEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1DisabledEnum2?>? Disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1HiddenEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1HiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1HiddenEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1HiddenEnum2?>? Hidden { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0603220ab3785539UiOptionVariant1" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
        /// <param name="hidden"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0603220ab3785539UiOptionVariant1(
            string label,
            string value,
            string? description,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1DisabledEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1DisabledEnum2?>? disabled,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1HiddenEnum, bool?, global::Vercel.AutoSDKShared0603220ab3785539UiOptionVariant1HiddenEnum2?>? hidden)
        {
            this.Description = description;
            this.Disabled = disabled;
            this.Hidden = hidden;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0603220ab3785539UiOptionVariant1" /> class.
        /// </summary>
        public AutoSDKShared0603220ab3785539UiOptionVariant1()
        {
        }

    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedceccd47983fcf9deVariant6UiOption
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionDisabledEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionDisabledEnum2?>? Disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionHiddenEnum2?>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionHiddenEnum2?>? Hidden { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant6UiOption" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
        /// <param name="hidden"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedceccd47983fcf9deVariant6UiOption(
            string label,
            string value,
            string? description,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionDisabledEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionDisabledEnum2?>? disabled,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionHiddenEnum, bool?, global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6UiOptionHiddenEnum2?>? hidden)
        {
            this.Description = description;
            this.Disabled = disabled;
            this.Hidden = hidden;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant6UiOption" /> class.
        /// </summary>
        public AutoSDKSharedceccd47983fcf9deVariant6UiOption()
        {
        }

    }
}
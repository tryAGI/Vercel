
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseDismissedToast
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DismissedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseDismissedToastActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseDismissedToastAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.UpdateMicrofrontendsResponseDismissedToastValue, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.UpdateMicrofrontendsResponseDismissedToastValue, bool?>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseDismissedToast" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dismissedAt"></param>
        /// <param name="action"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseDismissedToast(
            string key,
            double dismissedAt,
            global::Vercel.UpdateMicrofrontendsResponseDismissedToastAction action,
            global::Vercel.OneOf<string, double?, global::Vercel.UpdateMicrofrontendsResponseDismissedToastValue, bool?>? value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.DismissedAt = dismissedAt;
            this.Action = action;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseDismissedToast" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseDismissedToast()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestDismissedToast
    {
        /// <summary>
        /// unique identifier for the dismissed toast
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// unix timestamp representing the time the toast was dimissed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DismissedAt { get; set; }

        /// <summary>
        /// Whether the toast was dismissed, the action was accepted, or the dismissal with this key should be removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestDismissedToastActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestDismissedToastAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, string, bool?, double?, global::Vercel.UpdateProjectRequestDismissedToastValue>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, string, bool?, double?, global::Vercel.UpdateProjectRequestDismissedToastValue> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDismissedToast" /> class.
        /// </summary>
        /// <param name="key">
        /// unique identifier for the dismissed toast
        /// </param>
        /// <param name="dismissedAt">
        /// unix timestamp representing the time the toast was dimissed
        /// </param>
        /// <param name="action">
        /// Whether the toast was dismissed, the action was accepted, or the dismissal with this key should be removed
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDismissedToast(
            string key,
            double dismissedAt,
            global::Vercel.UpdateProjectRequestDismissedToastAction action,
            global::Vercel.OneOf<string, string, bool?, double?, global::Vercel.UpdateProjectRequestDismissedToastValue> value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.DismissedAt = dismissedAt;
            this.Action = action;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDismissedToast" /> class.
        /// </summary>
        public UpdateProjectRequestDismissedToast()
        {
        }
    }
}
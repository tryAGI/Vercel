
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf5934c240f4382f7DismissedToast
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf5934c240f4382f7DismissedToastActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf5934c240f4382f7DismissedToastAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DismissedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.AutoSDKSharedf5934c240f4382f7DismissedToastValue, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKSharedf5934c240f4382f7DismissedToastValue, bool?>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7DismissedToast" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="dismissedAt"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf5934c240f4382f7DismissedToast(
            global::Vercel.AutoSDKSharedf5934c240f4382f7DismissedToastAction action,
            double dismissedAt,
            string key,
            global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKSharedf5934c240f4382f7DismissedToastValue, bool?>? value)
        {
            this.Action = action;
            this.DismissedAt = dismissedAt;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7DismissedToast" /> class.
        /// </summary>
        public AutoSDKSharedf5934c240f4382f7DismissedToast()
        {
        }

    }
}
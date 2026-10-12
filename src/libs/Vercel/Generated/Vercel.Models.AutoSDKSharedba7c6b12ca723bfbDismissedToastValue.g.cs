
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedba7c6b12ca723bfbDismissedToastValue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, double?, bool?> CurrentValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, double?, bool?> PreviousValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbDismissedToastValue" /> class.
        /// </summary>
        /// <param name="currentValue"></param>
        /// <param name="previousValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedba7c6b12ca723bfbDismissedToastValue(
            global::Vercel.OneOf<string, double?, bool?> currentValue,
            global::Vercel.OneOf<string, double?, bool?> previousValue)
        {
            this.CurrentValue = currentValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbDismissedToastValue" /> class.
        /// </summary>
        public AutoSDKSharedba7c6b12ca723bfbDismissedToastValue()
        {
        }

    }
}
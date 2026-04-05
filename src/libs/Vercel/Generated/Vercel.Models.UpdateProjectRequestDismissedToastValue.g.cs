
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestDismissedToastValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<double?, bool?, string> PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<double?, bool?, string> CurrentValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDismissedToastValue" /> class.
        /// </summary>
        /// <param name="previousValue"></param>
        /// <param name="currentValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDismissedToastValue(
            global::Vercel.OneOf<double?, bool?, string> previousValue,
            global::Vercel.OneOf<double?, bool?, string> currentValue)
        {
            this.PreviousValue = previousValue;
            this.CurrentValue = currentValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDismissedToastValue" /> class.
        /// </summary>
        public UpdateProjectRequestDismissedToastValue()
        {
        }
    }
}
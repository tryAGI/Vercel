
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseDismissedToastValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, double?, bool?> PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, double?, bool?> CurrentValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseDismissedToastValue" /> class.
        /// </summary>
        /// <param name="previousValue"></param>
        /// <param name="currentValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseDismissedToastValue(
            global::Vercel.OneOf<string, double?, bool?> previousValue,
            global::Vercel.OneOf<string, double?, bool?> currentValue)
        {
            this.PreviousValue = previousValue;
            this.CurrentValue = currentValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseDismissedToastValue" /> class.
        /// </summary>
        public CreateProjectResponseDismissedToastValue()
        {
        }
    }
}
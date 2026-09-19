
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetCheckResponseOutputMetricsVirtualExperienceScore
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        public double? PreviousValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetCheckResponseOutputMetricsVirtualExperienceScoreSourceJsonConverter))]
        public global::Vercel.GetCheckResponseOutputMetricsVirtualExperienceScoreSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckResponseOutputMetricsVirtualExperienceScore" /> class.
        /// </summary>
        /// <param name="previousValue"></param>
        /// <param name="source"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCheckResponseOutputMetricsVirtualExperienceScore(
            double? previousValue,
            global::Vercel.GetCheckResponseOutputMetricsVirtualExperienceScoreSource source,
            double? value)
        {
            this.PreviousValue = previousValue;
            this.Source = source;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckResponseOutputMetricsVirtualExperienceScore" /> class.
        /// </summary>
        public GetCheckResponseOutputMetricsVirtualExperienceScore()
        {
        }

    }
}
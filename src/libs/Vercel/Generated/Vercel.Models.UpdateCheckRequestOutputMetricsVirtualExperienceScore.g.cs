
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCheckRequestOutputMetricsVirtualExperienceScore
    {
        /// <summary>
        /// The calculated Virtual Experience Score value, between 0 and 100<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// A previous Virtual Experience Score value to display a delta, between 0 and 100<br/>
        /// Example: 35
        /// </summary>
        /// <example>35</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        public int? PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestOutputMetricsVirtualExperienceScoreSourceJsonConverter))]
        public global::Vercel.UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsVirtualExperienceScore" /> class.
        /// </summary>
        /// <param name="value">
        /// The calculated Virtual Experience Score value, between 0 and 100<br/>
        /// Example: 30
        /// </param>
        /// <param name="previousValue">
        /// A previous Virtual Experience Score value to display a delta, between 0 and 100<br/>
        /// Example: 35
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutputMetricsVirtualExperienceScore(
            int? value,
            int? previousValue,
            global::Vercel.UpdateCheckRequestOutputMetricsVirtualExperienceScoreSource source)
        {
            this.Value = value;
            this.PreviousValue = previousValue;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsVirtualExperienceScore" /> class.
        /// </summary>
        public UpdateCheckRequestOutputMetricsVirtualExperienceScore()
        {
        }
    }
}
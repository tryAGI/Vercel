
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCheckRequestOutputMetricsTbt
    {
        /// <summary>
        /// Total Blocking Time value<br/>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Previous Total Blocking Time value to display a delta<br/>
        /// Example: 3500
        /// </summary>
        /// <example>3500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        public double? PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestOutputMetricsTbtSourceJsonConverter))]
        public global::Vercel.UpdateCheckRequestOutputMetricsTbtSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsTbt" /> class.
        /// </summary>
        /// <param name="value">
        /// Total Blocking Time value<br/>
        /// Example: 3000
        /// </param>
        /// <param name="previousValue">
        /// Previous Total Blocking Time value to display a delta<br/>
        /// Example: 3500
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutputMetricsTbt(
            double? value,
            double? previousValue,
            global::Vercel.UpdateCheckRequestOutputMetricsTbtSource source)
        {
            this.Value = value;
            this.PreviousValue = previousValue;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsTbt" /> class.
        /// </summary>
        public UpdateCheckRequestOutputMetricsTbt()
        {
        }
    }
}
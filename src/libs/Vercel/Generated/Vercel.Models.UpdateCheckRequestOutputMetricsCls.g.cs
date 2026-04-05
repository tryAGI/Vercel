
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCheckRequestOutputMetricsCls
    {
        /// <summary>
        /// Cumulative Layout Shift value<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Previous Cumulative Layout Shift value to display a delta<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        public double? PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestOutputMetricsClsSourceJsonConverter))]
        public global::Vercel.UpdateCheckRequestOutputMetricsClsSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsCls" /> class.
        /// </summary>
        /// <param name="value">
        /// Cumulative Layout Shift value<br/>
        /// Example: 4
        /// </param>
        /// <param name="previousValue">
        /// Previous Cumulative Layout Shift value to display a delta<br/>
        /// Example: 2
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutputMetricsCls(
            double? value,
            double? previousValue,
            global::Vercel.UpdateCheckRequestOutputMetricsClsSource source)
        {
            this.Value = value;
            this.PreviousValue = previousValue;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsCls" /> class.
        /// </summary>
        public UpdateCheckRequestOutputMetricsCls()
        {
        }
    }
}
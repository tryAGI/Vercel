
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCheckResponseOutputMetricsCls
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckResponseOutputMetricsClsSourceJsonConverter))]
        public global::Vercel.UpdateCheckResponseOutputMetricsClsSource Source { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateCheckResponseOutputMetricsCls" /> class.
        /// </summary>
        /// <param name="previousValue"></param>
        /// <param name="source"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckResponseOutputMetricsCls(
            double? previousValue,
            global::Vercel.UpdateCheckResponseOutputMetricsClsSource source,
            double? value)
        {
            this.PreviousValue = previousValue;
            this.Source = source;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckResponseOutputMetricsCls" /> class.
        /// </summary>
        public UpdateCheckResponseOutputMetricsCls()
        {
        }

    }
}
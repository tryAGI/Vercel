
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCheckRequestOutputMetricsLcp
    {
        /// <summary>
        /// Largest Contentful Paint value<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Previous Largest Contentful Paint value to display a delta<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        public double? PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestOutputMetricsLcpSourceJsonConverter))]
        public global::Vercel.UpdateCheckRequestOutputMetricsLcpSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsLcp" /> class.
        /// </summary>
        /// <param name="value">
        /// Largest Contentful Paint value<br/>
        /// Example: 1200
        /// </param>
        /// <param name="previousValue">
        /// Previous Largest Contentful Paint value to display a delta<br/>
        /// Example: 1000
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutputMetricsLcp(
            double? value,
            double? previousValue,
            global::Vercel.UpdateCheckRequestOutputMetricsLcpSource source)
        {
            this.Value = value;
            this.PreviousValue = previousValue;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsLcp" /> class.
        /// </summary>
        public UpdateCheckRequestOutputMetricsLcp()
        {
        }
    }
}
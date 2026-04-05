
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCheckRequestOutputMetricsFcp
    {
        /// <summary>
        /// First Contentful Paint value<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Previous First Contentful Paint value to display a delta<br/>
        /// Example: 900
        /// </summary>
        /// <example>900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousValue")]
        public double? PreviousValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestOutputMetricsFcpSourceJsonConverter))]
        public global::Vercel.UpdateCheckRequestOutputMetricsFcpSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsFcp" /> class.
        /// </summary>
        /// <param name="value">
        /// First Contentful Paint value<br/>
        /// Example: 1200
        /// </param>
        /// <param name="previousValue">
        /// Previous First Contentful Paint value to display a delta<br/>
        /// Example: 900
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutputMetricsFcp(
            double? value,
            double? previousValue,
            global::Vercel.UpdateCheckRequestOutputMetricsFcpSource source)
        {
            this.Value = value;
            this.PreviousValue = previousValue;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetricsFcp" /> class.
        /// </summary>
        public UpdateCheckRequestOutputMetricsFcp()
        {
        }
    }
}
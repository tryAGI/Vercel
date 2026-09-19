
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The checks to evaluate. An empty array means nothing is evaluated.
    /// </summary>
    public sealed partial class GetProjectResponseRollingReleaseGateCheck
    {
        /// <summary>
        /// Request paths to ignore entirely — dropped from both the numerator (errors) and the denominator (total requests). Matched exactly against the request path with any query string removed; no prefix or glob matching. Defaults to `[]` when omitted.<br/>
        /// Example: [/api/health]
        /// </summary>
        /// <example>[/api/health]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludePaths")]
        public global::System.Collections.Generic.IList<string>? ExcludePaths { get; set; }

        /// <summary>
        /// Response status codes to ignore entirely — dropped from both the numerator (errors) and the denominator (total requests). Defaults to `[]` when omitted.<br/>
        /// Example: [503]
        /// </summary>
        /// <example>[503]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeStatusCodes")]
        public global::System.Collections.Generic.IList<double>? ExcludeStatusCodes { get; set; }

        /// <summary>
        /// Seconds of ingest lag to allow for: the query's upper bound is `now() - this value`, so the check never reads a window that is still filling. Defaults to `30` when omitted.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestWatermarkSeconds")]
        public double? IngestWatermarkSeconds { get; set; }

        /// <summary>
        /// Minimum number of requests required in the window before the check can fail. Below this, the check is inconclusive rather than failing, so low-traffic stages don't gate on noise. Defaults to `100` when omitted.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("minSampleSize")]
        public double? MinSampleSize { get; set; }

        /// <summary>
        /// The metric this check evaluates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseRollingReleaseGateCheckTypeJsonConverter))]
        public global::Vercel.GetProjectResponseRollingReleaseGateCheckType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseRollingReleaseGateCheck" /> class.
        /// </summary>
        /// <param name="excludePaths">
        /// Request paths to ignore entirely — dropped from both the numerator (errors) and the denominator (total requests). Matched exactly against the request path with any query string removed; no prefix or glob matching. Defaults to `[]` when omitted.<br/>
        /// Example: [/api/health]
        /// </param>
        /// <param name="excludeStatusCodes">
        /// Response status codes to ignore entirely — dropped from both the numerator (errors) and the denominator (total requests). Defaults to `[]` when omitted.<br/>
        /// Example: [503]
        /// </param>
        /// <param name="ingestWatermarkSeconds">
        /// Seconds of ingest lag to allow for: the query's upper bound is `now() - this value`, so the check never reads a window that is still filling. Defaults to `30` when omitted.<br/>
        /// Example: 30
        /// </param>
        /// <param name="minSampleSize">
        /// Minimum number of requests required in the window before the check can fail. Below this, the check is inconclusive rather than failing, so low-traffic stages don't gate on noise. Defaults to `100` when omitted.<br/>
        /// Example: 100
        /// </param>
        /// <param name="type">
        /// The metric this check evaluates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseRollingReleaseGateCheck(
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<double>? excludeStatusCodes,
            double? ingestWatermarkSeconds,
            double? minSampleSize,
            global::Vercel.GetProjectResponseRollingReleaseGateCheckType type)
        {
            this.ExcludePaths = excludePaths;
            this.ExcludeStatusCodes = excludeStatusCodes;
            this.IngestWatermarkSeconds = ingestWatermarkSeconds;
            this.MinSampleSize = minSampleSize;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseRollingReleaseGateCheck" /> class.
        /// </summary>
        public GetProjectResponseRollingReleaseGateCheck()
        {
        }

    }
}
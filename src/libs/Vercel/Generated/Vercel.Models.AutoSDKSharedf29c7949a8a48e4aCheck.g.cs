
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The checks to evaluate. An empty array means nothing is evaluated.
    /// </summary>
    public sealed partial class AutoSDKSharedf29c7949a8a48e4aCheck
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
        /// A run fails only when the canary's error rate is higher and its one-sided Fisher p-value is below this significance level. Defaults to `0.05`; lower values require stronger evidence.<br/>
        /// Example: 0.05F
        /// </summary>
        /// <example>0.05F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("significanceLevel")]
        public double? SignificanceLevel { get; set; }

        /// <summary>
        /// The metric this check evaluates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf29c7949a8a48e4aCheckTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedf29c7949a8a48e4aCheckType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf29c7949a8a48e4aCheck" /> class.
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
        /// <param name="significanceLevel">
        /// A run fails only when the canary's error rate is higher and its one-sided Fisher p-value is below this significance level. Defaults to `0.05`; lower values require stronger evidence.<br/>
        /// Example: 0.05F
        /// </param>
        /// <param name="type">
        /// The metric this check evaluates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf29c7949a8a48e4aCheck(
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<double>? excludeStatusCodes,
            double? ingestWatermarkSeconds,
            double? significanceLevel,
            global::Vercel.AutoSDKSharedf29c7949a8a48e4aCheckType type)
        {
            this.ExcludePaths = excludePaths;
            this.ExcludeStatusCodes = excludeStatusCodes;
            this.IngestWatermarkSeconds = ingestWatermarkSeconds;
            this.SignificanceLevel = significanceLevel;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf29c7949a8a48e4aCheck" /> class.
        /// </summary>
        public AutoSDKSharedf29c7949a8a48e4aCheck()
        {
        }

    }
}
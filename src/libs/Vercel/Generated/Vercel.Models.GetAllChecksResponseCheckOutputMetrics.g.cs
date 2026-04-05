
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllChecksResponseCheckOutputMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FCP")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAllChecksResponseCheckOutputMetricsFcp Fcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCP")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAllChecksResponseCheckOutputMetricsLcp Lcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CLS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAllChecksResponseCheckOutputMetricsCls Cls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TBT")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAllChecksResponseCheckOutputMetricsTbt Tbt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualExperienceScore")]
        public global::Vercel.GetAllChecksResponseCheckOutputMetricsVirtualExperienceScore? VirtualExperienceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllChecksResponseCheckOutputMetrics" /> class.
        /// </summary>
        /// <param name="fcp"></param>
        /// <param name="lcp"></param>
        /// <param name="cls"></param>
        /// <param name="tbt"></param>
        /// <param name="virtualExperienceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllChecksResponseCheckOutputMetrics(
            global::Vercel.GetAllChecksResponseCheckOutputMetricsFcp fcp,
            global::Vercel.GetAllChecksResponseCheckOutputMetricsLcp lcp,
            global::Vercel.GetAllChecksResponseCheckOutputMetricsCls cls,
            global::Vercel.GetAllChecksResponseCheckOutputMetricsTbt tbt,
            global::Vercel.GetAllChecksResponseCheckOutputMetricsVirtualExperienceScore? virtualExperienceScore)
        {
            this.Fcp = fcp ?? throw new global::System.ArgumentNullException(nameof(fcp));
            this.Lcp = lcp ?? throw new global::System.ArgumentNullException(nameof(lcp));
            this.Cls = cls ?? throw new global::System.ArgumentNullException(nameof(cls));
            this.Tbt = tbt ?? throw new global::System.ArgumentNullException(nameof(tbt));
            this.VirtualExperienceScore = virtualExperienceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllChecksResponseCheckOutputMetrics" /> class.
        /// </summary>
        public GetAllChecksResponseCheckOutputMetrics()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metrics about the page
    /// </summary>
    public sealed partial class UpdateCheckRequestOutputMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FCP")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateCheckRequestOutputMetricsFcp Fcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCP")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateCheckRequestOutputMetricsLcp Lcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CLS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateCheckRequestOutputMetricsCls Cls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TBT")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateCheckRequestOutputMetricsTbt Tbt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualExperienceScore")]
        public global::Vercel.UpdateCheckRequestOutputMetricsVirtualExperienceScore? VirtualExperienceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetrics" /> class.
        /// </summary>
        /// <param name="fcp"></param>
        /// <param name="lcp"></param>
        /// <param name="cls"></param>
        /// <param name="tbt"></param>
        /// <param name="virtualExperienceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequestOutputMetrics(
            global::Vercel.UpdateCheckRequestOutputMetricsFcp fcp,
            global::Vercel.UpdateCheckRequestOutputMetricsLcp lcp,
            global::Vercel.UpdateCheckRequestOutputMetricsCls cls,
            global::Vercel.UpdateCheckRequestOutputMetricsTbt tbt,
            global::Vercel.UpdateCheckRequestOutputMetricsVirtualExperienceScore? virtualExperienceScore)
        {
            this.Fcp = fcp ?? throw new global::System.ArgumentNullException(nameof(fcp));
            this.Lcp = lcp ?? throw new global::System.ArgumentNullException(nameof(lcp));
            this.Cls = cls ?? throw new global::System.ArgumentNullException(nameof(cls));
            this.Tbt = tbt ?? throw new global::System.ArgumentNullException(nameof(tbt));
            this.VirtualExperienceScore = virtualExperienceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequestOutputMetrics" /> class.
        /// </summary>
        public UpdateCheckRequestOutputMetrics()
        {
        }
    }
}
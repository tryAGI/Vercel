
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCheckResponseOutputMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FCP")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateCheckResponseOutputMetricsFcp Fcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCP")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateCheckResponseOutputMetricsLcp Lcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CLS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateCheckResponseOutputMetricsCls Cls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TBT")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateCheckResponseOutputMetricsTbt Tbt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualExperienceScore")]
        public global::Vercel.CreateCheckResponseOutputMetricsVirtualExperienceScore? VirtualExperienceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckResponseOutputMetrics" /> class.
        /// </summary>
        /// <param name="fcp"></param>
        /// <param name="lcp"></param>
        /// <param name="cls"></param>
        /// <param name="tbt"></param>
        /// <param name="virtualExperienceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCheckResponseOutputMetrics(
            global::Vercel.CreateCheckResponseOutputMetricsFcp fcp,
            global::Vercel.CreateCheckResponseOutputMetricsLcp lcp,
            global::Vercel.CreateCheckResponseOutputMetricsCls cls,
            global::Vercel.CreateCheckResponseOutputMetricsTbt tbt,
            global::Vercel.CreateCheckResponseOutputMetricsVirtualExperienceScore? virtualExperienceScore)
        {
            this.Fcp = fcp ?? throw new global::System.ArgumentNullException(nameof(fcp));
            this.Lcp = lcp ?? throw new global::System.ArgumentNullException(nameof(lcp));
            this.Cls = cls ?? throw new global::System.ArgumentNullException(nameof(cls));
            this.Tbt = tbt ?? throw new global::System.ArgumentNullException(nameof(tbt));
            this.VirtualExperienceScore = virtualExperienceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckResponseOutputMetrics" /> class.
        /// </summary>
        public CreateCheckResponseOutputMetrics()
        {
        }
    }
}
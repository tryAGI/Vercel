
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant224
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyticsId")]
        public string? AnalyticsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRatePercent")]
        public double? SampleRatePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spendLimitInDollars")]
        public double? SpendLimitInDollars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant224Previous Previous { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant224" /> class.
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="analyticsId"></param>
        /// <param name="sampleRatePercent"></param>
        /// <param name="spendLimitInDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant224(
            global::Vercel.UserEventPayloadVariant224Previous previous,
            string? projectId,
            string? projectName,
            string? analyticsId,
            double? sampleRatePercent,
            double? spendLimitInDollars)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.AnalyticsId = analyticsId;
            this.SampleRatePercent = sampleRatePercent;
            this.SpendLimitInDollars = spendLimitInDollars;
            this.Previous = previous ?? throw new global::System.ArgumentNullException(nameof(previous));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant224" /> class.
        /// </summary>
        public UserEventPayloadVariant224()
        {
        }
    }
}
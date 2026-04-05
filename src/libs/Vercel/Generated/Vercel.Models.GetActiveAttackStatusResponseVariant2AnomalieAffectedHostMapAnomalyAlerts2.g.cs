
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AtMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zscore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Zscore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequestsMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stddev_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StddevRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2" /> class.
        /// </summary>
        /// <param name="atMinute"></param>
        /// <param name="zscore"></param>
        /// <param name="totalRequestsMinute"></param>
        /// <param name="avgRequests"></param>
        /// <param name="stddevRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2(
            string atMinute,
            double zscore,
            double totalRequestsMinute,
            double avgRequests,
            double stddevRequests)
        {
            this.AtMinute = atMinute ?? throw new global::System.ArgumentNullException(nameof(atMinute));
            this.Zscore = zscore;
            this.TotalRequestsMinute = totalRequestsMinute;
            this.AvgRequests = avgRequests;
            this.StddevRequests = stddevRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2" /> class.
        /// </summary>
        public GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2()
        {
        }
    }
}
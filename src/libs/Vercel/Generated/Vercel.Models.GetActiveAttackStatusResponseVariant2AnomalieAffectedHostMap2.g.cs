
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anomalyAlerts")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2>? AnomalyAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddosAlerts")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2>? DdosAlerts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2" /> class.
        /// </summary>
        /// <param name="anomalyAlerts"></param>
        /// <param name="ddosAlerts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapAnomalyAlerts2>? anomalyAlerts,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2>? ddosAlerts)
        {
            this.AnomalyAlerts = anomalyAlerts;
            this.DdosAlerts = ddosAlerts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2" /> class.
        /// </summary>
        public GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2()
        {
        }
    }
}
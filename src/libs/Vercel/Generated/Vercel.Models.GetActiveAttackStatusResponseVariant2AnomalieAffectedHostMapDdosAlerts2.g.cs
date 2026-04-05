
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atMinute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AtMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalReqs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalReqs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2" /> class.
        /// </summary>
        /// <param name="atMinute"></param>
        /// <param name="totalReqs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2(
            string atMinute,
            double totalReqs)
        {
            this.AtMinute = atMinute ?? throw new global::System.ArgumentNullException(nameof(atMinute));
            this.TotalReqs = totalReqs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2" /> class.
        /// </summary>
        public GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMapDdosAlerts2()
        {
        }
    }
}
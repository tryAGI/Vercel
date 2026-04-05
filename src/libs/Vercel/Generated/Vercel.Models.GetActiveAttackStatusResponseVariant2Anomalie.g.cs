
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActiveAttackStatusResponseVariant2Anomalie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public double? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atMinute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AtMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedHostMap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2> AffectedHostMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2Anomalie" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ownerId"></param>
        /// <param name="startTime"></param>
        /// <param name="atMinute"></param>
        /// <param name="affectedHostMap"></param>
        /// <param name="endTime"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActiveAttackStatusResponseVariant2Anomalie(
            string projectId,
            string ownerId,
            double startTime,
            double atMinute,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetActiveAttackStatusResponseVariant2AnomalieAffectedHostMap2> affectedHostMap,
            double? endTime,
            string? state)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.AtMinute = atMinute;
            this.State = state;
            this.AffectedHostMap = affectedHostMap ?? throw new global::System.ArgumentNullException(nameof(affectedHostMap));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveAttackStatusResponseVariant2Anomalie" /> class.
        /// </summary>
        public GetActiveAttackStatusResponseVariant2Anomalie()
        {
        }
    }
}
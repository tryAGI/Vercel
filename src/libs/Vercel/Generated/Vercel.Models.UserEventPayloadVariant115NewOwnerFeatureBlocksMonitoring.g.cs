
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A soft block indicates a temporary pause in data collection (ex limit exceeded for the current cycle) A hard block indicates a stoppage in data collection that requires manual intervention (ex upgrading a pro trial)
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedFrom")]
        public double? BlockedFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedUntil")]
        public double? BlockedUntil { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockReason BlockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType BlockType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="blockReason"></param>
        /// <param name="blockType"></param>
        /// <param name="blockedFrom"></param>
        /// <param name="blockedUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring(
            double updatedAt,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockReason blockReason,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType blockType,
            double? blockedFrom,
            double? blockedUntil)
        {
            this.UpdatedAt = updatedAt;
            this.BlockedFrom = blockedFrom;
            this.BlockedUntil = blockedUntil;
            this.BlockReason = blockReason;
            this.BlockType = blockType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring()
        {
        }
    }
}
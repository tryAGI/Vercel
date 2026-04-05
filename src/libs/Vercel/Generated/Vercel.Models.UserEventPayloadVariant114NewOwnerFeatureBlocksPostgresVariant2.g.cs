
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2BlockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2BlockReason BlockReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="blockReason"></param>
        /// <param name="blockedFrom"></param>
        /// <param name="blockedUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2(
            double updatedAt,
            global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2BlockReason blockReason,
            double? blockedFrom,
            double? blockedUntil)
        {
            this.UpdatedAt = updatedAt;
            this.BlockedFrom = blockedFrom;
            this.BlockedUntil = blockedUntil;
            this.BlockReason = blockReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant2()
        {
        }
    }
}
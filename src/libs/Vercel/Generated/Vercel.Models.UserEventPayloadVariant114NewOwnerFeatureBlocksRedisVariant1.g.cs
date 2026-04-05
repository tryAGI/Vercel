
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1BlockReasonJsonConverter))]
        public global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1BlockReason BlockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overageReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason OverageReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="overageReason"></param>
        /// <param name="blockedFrom"></param>
        /// <param name="blockedUntil"></param>
        /// <param name="blockReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1(
            double updatedAt,
            global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason overageReason,
            double? blockedFrom,
            double? blockedUntil,
            global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1BlockReason blockReason)
        {
            this.UpdatedAt = updatedAt;
            this.BlockedFrom = blockedFrom;
            this.BlockedUntil = blockedUntil;
            this.BlockReason = blockReason;
            this.OverageReason = overageReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1()
        {
        }
    }
}
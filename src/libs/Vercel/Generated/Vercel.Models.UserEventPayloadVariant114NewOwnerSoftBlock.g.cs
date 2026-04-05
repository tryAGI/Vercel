
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerSoftBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BlockedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerSoftBlockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant114NewOwnerSoftBlockReason Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedDueToOverageType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType? BlockedDueToOverageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerSoftBlock" /> class.
        /// </summary>
        /// <param name="blockedAt"></param>
        /// <param name="reason"></param>
        /// <param name="blockedDueToOverageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerSoftBlock(
            double blockedAt,
            global::Vercel.UserEventPayloadVariant114NewOwnerSoftBlockReason reason,
            global::Vercel.UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType? blockedDueToOverageType)
        {
            this.BlockedAt = blockedAt;
            this.Reason = reason;
            this.BlockedDueToOverageType = blockedDueToOverageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerSoftBlock" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerSoftBlock()
        {
        }
    }
}
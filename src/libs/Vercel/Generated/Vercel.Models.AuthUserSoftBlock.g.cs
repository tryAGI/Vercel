
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When the User account has been "soft blocked", this property will contain the date when the restriction was enacted, and the identifier for why.
    /// </summary>
    public sealed partial class AuthUserSoftBlock
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserSoftBlockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthUserSoftBlockReason Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedDueToOverageType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserSoftBlockBlockedDueToOverageTypeJsonConverter))]
        public global::Vercel.AuthUserSoftBlockBlockedDueToOverageType? BlockedDueToOverageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserSoftBlock" /> class.
        /// </summary>
        /// <param name="blockedAt"></param>
        /// <param name="reason"></param>
        /// <param name="blockedDueToOverageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserSoftBlock(
            double blockedAt,
            global::Vercel.AuthUserSoftBlockReason reason,
            global::Vercel.AuthUserSoftBlockBlockedDueToOverageType? blockedDueToOverageType)
        {
            this.BlockedAt = blockedAt;
            this.Reason = reason;
            this.BlockedDueToOverageType = blockedDueToOverageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserSoftBlock" /> class.
        /// </summary>
        public AuthUserSoftBlock()
        {
        }
    }
}
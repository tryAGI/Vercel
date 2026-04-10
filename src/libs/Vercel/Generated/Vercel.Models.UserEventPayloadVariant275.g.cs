
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant275
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Totp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recoveryCodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecoveryCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        public string? ActorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant275ActorTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant275ActorType? ActorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant275" /> class.
        /// </summary>
        /// <param name="totp"></param>
        /// <param name="recoveryCodes"></param>
        /// <param name="actorId"></param>
        /// <param name="actorType"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant275(
            bool totp,
            double recoveryCodes,
            string? actorId,
            global::Vercel.UserEventPayloadVariant275ActorType? actorType,
            string? reason)
        {
            this.Totp = totp;
            this.RecoveryCodes = recoveryCodes;
            this.ActorId = actorId;
            this.ActorType = actorType;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant275" /> class.
        /// </summary>
        public UserEventPayloadVariant275()
        {
        }
    }
}
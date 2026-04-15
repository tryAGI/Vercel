
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant286
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totpVerified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TotpVerified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant286" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="totpVerified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant286(
            bool enabled,
            bool totpVerified)
        {
            this.Enabled = enabled;
            this.TotpVerified = totpVerified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant286" /> class.
        /// </summary>
        public UserEventPayloadVariant286()
        {
        }
    }
}
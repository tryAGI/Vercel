
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant273Previous
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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant273Previous" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="totpVerified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant273Previous(
            bool enabled,
            bool totpVerified)
        {
            this.Enabled = enabled;
            this.TotpVerified = totpVerified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant273Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant273Previous()
        {
        }
    }
}
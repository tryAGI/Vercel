
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant285
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfaEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MfaEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant285" /> class.
        /// </summary>
        /// <param name="mfaEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant285(
            bool mfaEnabled)
        {
            this.MfaEnabled = mfaEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant285" /> class.
        /// </summary>
        public UserEventPayloadVariant285()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlockCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant8" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="blockCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant8(
            string reason,
            string blockCode)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.BlockCode = blockCode ?? throw new global::System.ArgumentNullException(nameof(blockCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant8" /> class.
        /// </summary>
        public UserEventPayloadVariant8()
        {
        }
    }
}
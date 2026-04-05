
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant94
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigDigest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigDigest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant94" /> class.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigSlug"></param>
        /// <param name="edgeConfigDigest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant94(
            string edgeConfigId,
            string edgeConfigSlug,
            string edgeConfigDigest)
        {
            this.EdgeConfigId = edgeConfigId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigId));
            this.EdgeConfigSlug = edgeConfigSlug ?? throw new global::System.ArgumentNullException(nameof(edgeConfigSlug));
            this.EdgeConfigDigest = edgeConfigDigest ?? throw new global::System.ArgumentNullException(nameof(edgeConfigDigest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant94" /> class.
        /// </summary>
        public UserEventPayloadVariant94()
        {
        }
    }
}
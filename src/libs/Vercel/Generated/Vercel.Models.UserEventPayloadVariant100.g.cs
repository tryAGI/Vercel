
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant100
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
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigTokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigTokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant100" /> class.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigSlug"></param>
        /// <param name="edgeConfigTokenId"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant100(
            string edgeConfigId,
            string edgeConfigSlug,
            string edgeConfigTokenId,
            string label)
        {
            this.EdgeConfigId = edgeConfigId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigId));
            this.EdgeConfigSlug = edgeConfigSlug ?? throw new global::System.ArgumentNullException(nameof(edgeConfigSlug));
            this.EdgeConfigTokenId = edgeConfigTokenId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigTokenId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant100" /> class.
        /// </summary>
        public UserEventPayloadVariant100()
        {
        }
    }
}
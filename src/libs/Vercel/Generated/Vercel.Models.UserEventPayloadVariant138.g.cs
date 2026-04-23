
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant138
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant138TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant138Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant138" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant138(
            string projectId,
            string resourceUrl,
            global::Vercel.UserEventPayloadVariant138Type type)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Type = type;
            this.ResourceUrl = resourceUrl ?? throw new global::System.ArgumentNullException(nameof(resourceUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant138" /> class.
        /// </summary>
        public UserEventPayloadVariant138()
        {
        }
    }
}
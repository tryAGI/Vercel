
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant154
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateLinkEndpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant154PrivateLinkEndpoint PrivateLinkEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousEndpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant154PreviousEndpoint PreviousEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant154" /> class.
        /// </summary>
        /// <param name="privateLinkEndpoint"></param>
        /// <param name="projectId"></param>
        /// <param name="previousEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant154(
            global::Vercel.UserEventPayloadVariant154PrivateLinkEndpoint privateLinkEndpoint,
            string projectId,
            global::Vercel.UserEventPayloadVariant154PreviousEndpoint previousEndpoint)
        {
            this.PrivateLinkEndpoint = privateLinkEndpoint ?? throw new global::System.ArgumentNullException(nameof(privateLinkEndpoint));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.PreviousEndpoint = previousEndpoint ?? throw new global::System.ArgumentNullException(nameof(previousEndpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant154" /> class.
        /// </summary>
        public UserEventPayloadVariant154()
        {
        }
    }
}
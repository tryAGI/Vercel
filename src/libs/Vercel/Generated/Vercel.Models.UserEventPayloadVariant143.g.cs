
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant143
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateLinkEndpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant143PrivateLinkEndpoint PrivateLinkEndpoint { get; set; }

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
        public required global::Vercel.UserEventPayloadVariant143PreviousEndpoint PreviousEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant143" /> class.
        /// </summary>
        /// <param name="privateLinkEndpoint"></param>
        /// <param name="projectId"></param>
        /// <param name="previousEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant143(
            global::Vercel.UserEventPayloadVariant143PrivateLinkEndpoint privateLinkEndpoint,
            string projectId,
            global::Vercel.UserEventPayloadVariant143PreviousEndpoint previousEndpoint)
        {
            this.PrivateLinkEndpoint = privateLinkEndpoint ?? throw new global::System.ArgumentNullException(nameof(privateLinkEndpoint));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.PreviousEndpoint = previousEndpoint ?? throw new global::System.ArgumentNullException(nameof(previousEndpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant143" /> class.
        /// </summary>
        public UserEventPayloadVariant143()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant137
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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant137" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="url"></param>
        /// <param name="previousStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant137(
            string projectId,
            string url,
            string previousStatus)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PreviousStatus = previousStatus ?? throw new global::System.ArgumentNullException(nameof(previousStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant137" /> class.
        /// </summary>
        public UserEventPayloadVariant137()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant149
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
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerName")]
        public string? HeaderName { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant149" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="previousStatus"></param>
        /// <param name="url"></param>
        /// <param name="headerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant149(
            string projectId,
            string previousStatus,
            string? url,
            string? headerName)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Url = url;
            this.HeaderName = headerName;
            this.PreviousStatus = previousStatus ?? throw new global::System.ArgumentNullException(nameof(previousStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant149" /> class.
        /// </summary>
        public UserEventPayloadVariant149()
        {
        }
    }
}
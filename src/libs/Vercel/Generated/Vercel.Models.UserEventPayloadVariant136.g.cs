
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant136
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
        [global::System.Text.Json.Serialization.JsonPropertyName("headerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeaderName { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant136" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="headerName"></param>
        /// <param name="previousStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant136(
            string projectId,
            string headerName,
            string previousStatus)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.HeaderName = headerName ?? throw new global::System.ArgumentNullException(nameof(headerName));
            this.PreviousStatus = previousStatus ?? throw new global::System.ArgumentNullException(nameof(previousStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant136" /> class.
        /// </summary>
        public UserEventPayloadVariant136()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant217
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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectWebAnalytics")]
        public global::Vercel.UserEventPayloadVariant217ProjectWebAnalytics? ProjectWebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevProjectWebAnalytics")]
        public global::Vercel.UserEventPayloadVariant217PrevProjectWebAnalytics? PrevProjectWebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant217" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectWebAnalytics"></param>
        /// <param name="prevProjectWebAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant217(
            string projectId,
            string projectName,
            global::Vercel.UserEventPayloadVariant217ProjectWebAnalytics? projectWebAnalytics,
            global::Vercel.UserEventPayloadVariant217PrevProjectWebAnalytics? prevProjectWebAnalytics)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ProjectWebAnalytics = projectWebAnalytics;
            this.PrevProjectWebAnalytics = prevProjectWebAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant217" /> class.
        /// </summary>
        public UserEventPayloadVariant217()
        {
        }
    }
}
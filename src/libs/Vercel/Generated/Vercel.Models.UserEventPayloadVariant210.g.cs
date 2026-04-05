
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant210
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
        public global::Vercel.UserEventPayloadVariant210ProjectWebAnalytics? ProjectWebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevProjectWebAnalytics")]
        public global::Vercel.UserEventPayloadVariant210PrevProjectWebAnalytics? PrevProjectWebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant210" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectWebAnalytics"></param>
        /// <param name="prevProjectWebAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant210(
            string projectId,
            string projectName,
            global::Vercel.UserEventPayloadVariant210ProjectWebAnalytics? projectWebAnalytics,
            global::Vercel.UserEventPayloadVariant210PrevProjectWebAnalytics? prevProjectWebAnalytics)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ProjectWebAnalytics = projectWebAnalytics;
            this.PrevProjectWebAnalytics = prevProjectWebAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant210" /> class.
        /// </summary>
        public UserEventPayloadVariant210()
        {
        }
    }
}
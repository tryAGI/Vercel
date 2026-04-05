
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant140
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectAnalytics")]
        public global::Vercel.UserEventPayloadVariant140ProjectAnalytics? ProjectAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevProjectAnalytics")]
        public global::Vercel.UserEventPayloadVariant140PrevProjectAnalytics? PrevProjectAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant140" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectAnalytics"></param>
        /// <param name="prevProjectAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant140(
            string projectId,
            string? projectName,
            global::Vercel.UserEventPayloadVariant140ProjectAnalytics? projectAnalytics,
            global::Vercel.UserEventPayloadVariant140PrevProjectAnalytics? prevProjectAnalytics)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectAnalytics = projectAnalytics;
            this.PrevProjectAnalytics = prevProjectAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant140" /> class.
        /// </summary>
        public UserEventPayloadVariant140()
        {
        }
    }
}
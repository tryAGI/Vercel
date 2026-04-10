
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant166
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
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public string? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant166" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="previewDeploymentSuffix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant166(
            string projectId,
            string projectName,
            string? previewDeploymentSuffix)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant166" /> class.
        /// </summary>
        public UserEventPayloadVariant166()
        {
        }
    }
}
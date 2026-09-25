
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared3fd5b0acfe2f4f54SourceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentTargetSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentTargetSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3fd5b0acfe2f4f54SourceVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="deploymentId"></param>
        /// <param name="projectId"></param>
        /// <param name="deploymentTargetSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared3fd5b0acfe2f4f54SourceVariant2(
            string type,
            string deploymentId,
            string projectId,
            string deploymentTargetSlug)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DeploymentTargetSlug = deploymentTargetSlug ?? throw new global::System.ArgumentNullException(nameof(deploymentTargetSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3fd5b0acfe2f4f54SourceVariant2" /> class.
        /// </summary>
        public AutoSDKShared3fd5b0acfe2f4f54SourceVariant2()
        {
        }

    }
}
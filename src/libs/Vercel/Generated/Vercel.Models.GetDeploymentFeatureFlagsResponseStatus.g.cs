
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentFeatureFlagsResponseStatus
    {
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
        /// The HTTP status code from the flags discovery endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseStatus { get; set; }

        /// <summary>
        /// The number of flag definitions returned by the flags discovery endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FlagCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentFeatureFlagsResponseStatus" /> class.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="projectId"></param>
        /// <param name="responseStatus">
        /// The HTTP status code from the flags discovery endpoint.
        /// </param>
        /// <param name="flagCount">
        /// The number of flag definitions returned by the flags discovery endpoint.
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentFeatureFlagsResponseStatus(
            string deploymentId,
            string projectId,
            double responseStatus,
            double flagCount,
            double createdAt)
        {
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ResponseStatus = responseStatus;
            this.FlagCount = flagCount;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentFeatureFlagsResponseStatus" /> class.
        /// </summary>
        public GetDeploymentFeatureFlagsResponseStatus()
        {
        }
    }
}
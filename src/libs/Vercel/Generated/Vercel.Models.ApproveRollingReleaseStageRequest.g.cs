
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApproveRollingReleaseStageRequest
    {
        /// <summary>
        /// The index of the stage to transition to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextStageIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NextStageIndex { get; set; }

        /// <summary>
        /// The id of the canary deployment to approve for the next stage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canaryDeploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanaryDeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageRequest" /> class.
        /// </summary>
        /// <param name="nextStageIndex">
        /// The index of the stage to transition to
        /// </param>
        /// <param name="canaryDeploymentId">
        /// The id of the canary deployment to approve for the next stage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveRollingReleaseStageRequest(
            double nextStageIndex,
            string canaryDeploymentId)
        {
            this.NextStageIndex = nextStageIndex;
            this.CanaryDeploymentId = canaryDeploymentId ?? throw new global::System.ArgumentNullException(nameof(canaryDeploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageRequest" /> class.
        /// </summary>
        public ApproveRollingReleaseStageRequest()
        {
        }
    }
}
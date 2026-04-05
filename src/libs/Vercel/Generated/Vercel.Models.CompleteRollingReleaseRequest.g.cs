
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteRollingReleaseRequest
    {
        /// <summary>
        /// The ID of the canary deployment to complete
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
        /// Initializes a new instance of the <see cref="CompleteRollingReleaseRequest" /> class.
        /// </summary>
        /// <param name="canaryDeploymentId">
        /// The ID of the canary deployment to complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteRollingReleaseRequest(
            string canaryDeploymentId)
        {
            this.CanaryDeploymentId = canaryDeploymentId ?? throw new global::System.ArgumentNullException(nameof(canaryDeploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteRollingReleaseRequest" /> class.
        /// </summary>
        public CompleteRollingReleaseRequest()
        {
        }
    }
}
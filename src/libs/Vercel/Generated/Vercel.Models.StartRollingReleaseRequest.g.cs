
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartRollingReleaseRequest
    {
        /// <summary>
        /// The ID of the canary deployment to start the rolling release for
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
        /// Initializes a new instance of the <see cref="StartRollingReleaseRequest" /> class.
        /// </summary>
        /// <param name="canaryDeploymentId">
        /// The ID of the canary deployment to start the rolling release for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartRollingReleaseRequest(
            string canaryDeploymentId)
        {
            this.CanaryDeploymentId = canaryDeploymentId ?? throw new global::System.ArgumentNullException(nameof(canaryDeploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartRollingReleaseRequest" /> class.
        /// </summary>
        public StartRollingReleaseRequest()
        {
        }

    }
}
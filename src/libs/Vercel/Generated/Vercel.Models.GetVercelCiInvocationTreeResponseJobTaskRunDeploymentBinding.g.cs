
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiInvocationTreeResponseJobTaskRunDeploymentBinding
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
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentCreatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DeploymentCreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EventAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        public string? ReadyState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobTaskRunDeploymentBinding" /> class.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentCreatedAt"></param>
        /// <param name="eventAt"></param>
        /// <param name="readyState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiInvocationTreeResponseJobTaskRunDeploymentBinding(
            string deploymentId,
            double deploymentCreatedAt,
            double eventAt,
            string? readyState)
        {
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DeploymentCreatedAt = deploymentCreatedAt;
            this.EventAt = eventAt;
            this.ReadyState = readyState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobTaskRunDeploymentBinding" /> class.
        /// </summary>
        public GetVercelCiInvocationTreeResponseJobTaskRunDeploymentBinding()
        {
        }

    }
}
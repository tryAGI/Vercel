
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentManualProvisioning
    {
        /// <summary>
        /// Current provisioning state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentManualProvisioningStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentManualProvisioningState State { get; set; }

        /// <summary>
        /// Timestamp when manual provisioning completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentManualProvisioning" /> class.
        /// </summary>
        /// <param name="state">
        /// Current provisioning state
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when manual provisioning completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentManualProvisioning(
            global::Vercel.GetDeploymentsResponseDeploymentManualProvisioningState state,
            double? completedAt)
        {
            this.State = state;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentManualProvisioning" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentManualProvisioning()
        {
        }
    }
}
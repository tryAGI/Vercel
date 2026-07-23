
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Present when deployment was created with manual provisioning enabled, either explicitly or via the experimental BYOC git flow. The deployment stays in INITIALIZING until /continue is called.
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ManualProvisioning
    {
        /// <summary>
        /// Current provisioning state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ManualProvisioningStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseVariant2ManualProvisioningState State { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ManualProvisioning" /> class.
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
        public CreateDeploymentResponseVariant2ManualProvisioning(
            global::Vercel.CreateDeploymentResponseVariant2ManualProvisioningState state,
            double? completedAt)
        {
            this.State = state;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ManualProvisioning" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ManualProvisioning()
        {
        }

    }
}
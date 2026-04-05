
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Detailed information about v2 deployment checks. Includes information about blocked workflows in the deployment lifecycle.
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentChecks
    {
        /// <summary>
        /// Detailed information about v2 deployment checks. Includes information about blocked workflows in the deployment lifecycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment-alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentChecksDeploymentAlias DeploymentAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentChecks" /> class.
        /// </summary>
        /// <param name="deploymentAlias">
        /// Detailed information about v2 deployment checks. Includes information about blocked workflows in the deployment lifecycle.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentChecks(
            global::Vercel.GetDeploymentsResponseDeploymentChecksDeploymentAlias deploymentAlias)
        {
            this.DeploymentAlias = deploymentAlias ?? throw new global::System.ArgumentNullException(nameof(deploymentAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentChecks" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentChecks()
        {
        }
    }
}
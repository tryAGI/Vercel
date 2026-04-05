
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseChecks
    {
        /// <summary>
        /// Condensed check data. Retrieve individual check and check run data using api-checks v2 routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment-alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseChecksDeploymentAlias DeploymentAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseChecks" /> class.
        /// </summary>
        /// <param name="deploymentAlias">
        /// Condensed check data. Retrieve individual check and check run data using api-checks v2 routes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseChecks(
            global::Vercel.CancelDeploymentResponseChecksDeploymentAlias deploymentAlias)
        {
            this.DeploymentAlias = deploymentAlias ?? throw new global::System.ArgumentNullException(nameof(deploymentAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseChecks" /> class.
        /// </summary>
        public CancelDeploymentResponseChecks()
        {
        }
    }
}
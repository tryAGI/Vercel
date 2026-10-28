
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseChecks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment-alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseChecksDeploymentAlias DeploymentAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseChecks" /> class.
        /// </summary>
        /// <param name="deploymentAlias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseChecks(
            global::Vercel.CreateDeploymentResponseChecksDeploymentAlias deploymentAlias)
        {
            this.DeploymentAlias = deploymentAlias ?? throw new global::System.ArgumentNullException(nameof(deploymentAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseChecks" /> class.
        /// </summary>
        public CreateDeploymentResponseChecks()
        {
        }

    }
}
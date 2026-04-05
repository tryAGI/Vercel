
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamDefaultDeploymentProtectionPasswordProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultDeploymentProtectionPasswordProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDefaultDeploymentProtectionPasswordProtection(
            string deploymentType)
        {
            this.DeploymentType = deploymentType ?? throw new global::System.ArgumentNullException(nameof(deploymentType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultDeploymentProtectionPasswordProtection" /> class.
        /// </summary>
        public TeamDefaultDeploymentProtectionPasswordProtection()
        {
        }
    }
}
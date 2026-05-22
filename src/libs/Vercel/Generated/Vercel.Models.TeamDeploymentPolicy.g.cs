
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Composable deployment-time policy for the team. Used as the default for every project on the team, with optional per-project overrides on `project.deploymentPolicy`.
    /// </summary>
    public sealed partial class TeamDeploymentPolicy
    {
        /// <summary>
        /// Restricts inbound Git deployments to an allowlist of orgs and/or repos. `enabled: true` with an empty `sources` list is treated as deny-all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        public global::Vercel.TeamDeploymentPolicyGitSources? GitSources { get; set; }

        /// <summary>
        /// Restricts which deployment sources are allowed. A deployment passes if its source is in `sources`. Multiple entries are evaluated as OR. `enabled: true` with an empty `sources` list is treated as deny-all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        public global::Vercel.TeamDeploymentPolicyDeploymentSources? DeploymentSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicy" /> class.
        /// </summary>
        /// <param name="gitSources">
        /// Restricts inbound Git deployments to an allowlist of orgs and/or repos. `enabled: true` with an empty `sources` list is treated as deny-all.
        /// </param>
        /// <param name="deploymentSources">
        /// Restricts which deployment sources are allowed. A deployment passes if its source is in `sources`. Multiple entries are evaluated as OR. `enabled: true` with an empty `sources` list is treated as deny-all.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDeploymentPolicy(
            global::Vercel.TeamDeploymentPolicyGitSources? gitSources,
            global::Vercel.TeamDeploymentPolicyDeploymentSources? deploymentSources)
        {
            this.GitSources = gitSources;
            this.DeploymentSources = deploymentSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicy" /> class.
        /// </summary>
        public TeamDeploymentPolicy()
        {
        }

    }
}
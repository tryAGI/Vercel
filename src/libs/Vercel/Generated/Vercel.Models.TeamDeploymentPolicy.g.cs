
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Composable deployment-time policy for the team. Used as the default for every project on the team, with optional per-project overrides on `project.deploymentPolicy`.
    /// </summary>
    public sealed partial class TeamDeploymentPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamDeploymentPolicyGitSource>? GitSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamDeploymentPolicyDeploymentSource>? DeploymentSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicy" /> class.
        /// </summary>
        /// <param name="gitSources"></param>
        /// <param name="deploymentSources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDeploymentPolicy(
            global::System.Collections.Generic.IList<global::Vercel.TeamDeploymentPolicyGitSource>? gitSources,
            global::System.Collections.Generic.IList<global::Vercel.TeamDeploymentPolicyDeploymentSource>? deploymentSources)
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
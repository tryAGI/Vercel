
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project shape. `null` on a rule list clears the project's override for that rule type (fall back to team for every env); omitting is equivalent. Setting `deploymentPolicy` itself to `null` clears every override at once. Kept structurally distinct from {@link TeamDeploymentPolicy} so the two storage locations don't share a type by accident.
    /// </summary>
    public sealed partial class GetProjectResponseDeploymentPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseDeploymentPolicyGitSource>? GitSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSource>? DeploymentSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseDeploymentPolicy" /> class.
        /// </summary>
        /// <param name="gitSources"></param>
        /// <param name="deploymentSources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseDeploymentPolicy(
            global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseDeploymentPolicyGitSource>? gitSources,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSource>? deploymentSources)
        {
            this.GitSources = gitSources;
            this.DeploymentSources = deploymentSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseDeploymentPolicy" /> class.
        /// </summary>
        public GetProjectResponseDeploymentPolicy()
        {
        }

    }
}
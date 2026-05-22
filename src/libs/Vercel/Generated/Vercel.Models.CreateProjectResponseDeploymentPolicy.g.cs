
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project-level shape. Each rule may be: - an object: overrides the team's value for that rule - `null`: explicitly clears the override on just that rule (inherit team) - omitted: inherit team To clear all overrides and inherit fully, set the project's `deploymentPolicy` field itself to `null`. Defined independently from {@link TeamDeploymentPolicy} so the two are not coupled by a shared type — the underlying data lives in separate stores.
    /// </summary>
    public sealed partial class CreateProjectResponseDeploymentPolicy
    {
        /// <summary>
        /// Restricts inbound Git deployments to an allowlist of orgs and/or repos. `enabled: true` with an empty `sources` list is treated as deny-all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        public global::Vercel.CreateProjectResponseDeploymentPolicyGitSources? GitSources { get; set; }

        /// <summary>
        /// Restricts which deployment sources are allowed. A deployment passes if its source is in `sources`. Multiple entries are evaluated as OR. `enabled: true` with an empty `sources` list is treated as deny-all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        public global::Vercel.CreateProjectResponseDeploymentPolicyDeploymentSources? DeploymentSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseDeploymentPolicy" /> class.
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
        public CreateProjectResponseDeploymentPolicy(
            global::Vercel.CreateProjectResponseDeploymentPolicyGitSources? gitSources,
            global::Vercel.CreateProjectResponseDeploymentPolicyDeploymentSources? deploymentSources)
        {
            this.GitSources = gitSources;
            this.DeploymentSources = deploymentSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseDeploymentPolicy" /> class.
        /// </summary>
        public CreateProjectResponseDeploymentPolicy()
        {
        }

    }
}
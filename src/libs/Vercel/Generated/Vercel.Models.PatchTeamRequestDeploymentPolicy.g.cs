
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Composable deployment-time policy. Each rule key controls an independent restriction.
    /// </summary>
    public sealed partial class PatchTeamRequestDeploymentPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.PatchTeamRequestDeploymentPolicyGitSources, string>))]
        public global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSources, string>? GitSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSources, string>))]
        public global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSources, string>? DeploymentSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicDeployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.PatchTeamRequestDeploymentPolicyPublicDeployments, string>))]
        public global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyPublicDeployments, string>? PublicDeployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicy" /> class.
        /// </summary>
        /// <param name="gitSources"></param>
        /// <param name="deploymentSources"></param>
        /// <param name="publicDeployments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDeploymentPolicy(
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSources, string>? gitSources,
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSources, string>? deploymentSources,
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyPublicDeployments, string>? publicDeployments)
        {
            this.GitSources = gitSources;
            this.DeploymentSources = deploymentSources;
            this.PublicDeployments = publicDeployments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicy" /> class.
        /// </summary>
        public PatchTeamRequestDeploymentPolicy()
        {
        }
    }
}
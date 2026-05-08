
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Composable deployment-time policy. Each rule key controls an independent restriction.
    /// </summary>
    public sealed partial class UpdateProjectRequestDeploymentPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSources, string>))]
        public global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSources, string>? GitSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSources, string>))]
        public global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSources, string>? DeploymentSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicDeployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateProjectRequestDeploymentPolicyPublicDeployments, string>))]
        public global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyPublicDeployments, string>? PublicDeployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicy" /> class.
        /// </summary>
        /// <param name="gitSources"></param>
        /// <param name="deploymentSources"></param>
        /// <param name="publicDeployments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDeploymentPolicy(
            global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSources, string>? gitSources,
            global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSources, string>? deploymentSources,
            global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyPublicDeployments, string>? publicDeployments)
        {
            this.GitSources = gitSources;
            this.DeploymentSources = deploymentSources;
            this.PublicDeployments = publicDeployments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicy" /> class.
        /// </summary>
        public UpdateProjectRequestDeploymentPolicy()
        {
        }
    }
}
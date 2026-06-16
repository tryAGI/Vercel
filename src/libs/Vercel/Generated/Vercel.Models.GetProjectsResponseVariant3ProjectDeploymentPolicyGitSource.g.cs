
#nullable enable

namespace Vercel
{
    /// <summary>
    /// `enabled: true` with empty `sources` is deny-all.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1, global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant2>> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1, global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant2>> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectDeploymentPolicyGitSource" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="enabled"></param>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectDeploymentPolicyGitSource(
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1, global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant2>> sources,
            bool enabled,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1, global::Vercel.GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant2>> environments)
        {
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Enabled = enabled;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectDeploymentPolicyGitSource" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectDeploymentPolicyGitSource()
        {
        }

    }
}
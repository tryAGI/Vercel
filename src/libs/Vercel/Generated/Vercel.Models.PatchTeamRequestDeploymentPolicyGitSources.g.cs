
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTeamRequestDeploymentPolicyGitSources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1, global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant2>>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesSource> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicyGitSources" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="sources"></param>
        /// <param name="id"></param>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDeploymentPolicyGitSources(
            bool enabled,
            global::System.Collections.Generic.IList<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesSource> sources,
            string? id,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1, global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant2>>? environments)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Environments = environments;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicyGitSources" /> class.
        /// </summary>
        public PatchTeamRequestDeploymentPolicyGitSources()
        {
        }

    }
}
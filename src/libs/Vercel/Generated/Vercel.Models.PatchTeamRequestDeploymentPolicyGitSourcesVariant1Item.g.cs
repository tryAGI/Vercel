
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchTeamRequestDeploymentPolicyGitSourcesVariant1Item
    {
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
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1, global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2>> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1, global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2>> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicyGitSourcesVariant1Item" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="environments"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDeploymentPolicyGitSourcesVariant1Item(
            bool enabled,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1, global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2>> environments,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1, global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2>> sources)
        {
            this.Enabled = enabled;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicyGitSourcesVariant1Item" /> class.
        /// </summary>
        public PatchTeamRequestDeploymentPolicyGitSourcesVariant1Item()
        {
        }

    }
}
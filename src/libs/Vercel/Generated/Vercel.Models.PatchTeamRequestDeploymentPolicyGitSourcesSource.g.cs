
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTeamRequestDeploymentPolicyGitSourcesSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestDeploymentPolicyGitSourcesSourceProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesSourceProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicyGitSourcesSource" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDeploymentPolicyGitSourcesSource(
            global::Vercel.PatchTeamRequestDeploymentPolicyGitSourcesSourceProvider provider,
            string org,
            string? repo)
        {
            this.Provider = provider;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Repo = repo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDeploymentPolicyGitSourcesSource" /> class.
        /// </summary>
        public PatchTeamRequestDeploymentPolicyGitSourcesSource()
        {
        }

    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1Item
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
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1, global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2>> Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSource> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyGitSourcesVariant1Item" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="environments"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDeploymentPolicyGitSourcesVariant1Item(
            bool enabled,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1, global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2>> environments,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSource> sources)
        {
            this.Enabled = enabled;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyGitSourcesVariant1Item" /> class.
        /// </summary>
        public UpdateProjectRequestDeploymentPolicyGitSourcesVariant1Item()
        {
        }

    }
}
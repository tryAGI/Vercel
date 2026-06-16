
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2ProviderJsonConverter))]
        public global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="provider"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2(
            string @namespace,
            global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider provider,
            string? project)
        {
            this.Provider = provider;
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2" /> class.
        /// </summary>
        public UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2()
        {
        }

    }
}
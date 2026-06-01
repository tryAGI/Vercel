
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allowlist entry for GitLab, which uses nested groups rather than a flat org/repo. `namespace` is the full group path (e.g. `group` or `group/subgroup`); `project` is the leaf project name. Omit `project` to match any project under the namespace. Namespace is matched case-insensitively.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2ProviderJsonConverter))]
        public global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider Provider { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="provider"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2(
            string @namespace,
            global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider provider,
            string? project)
        {
            this.Provider = provider;
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2()
        {
        }

    }
}
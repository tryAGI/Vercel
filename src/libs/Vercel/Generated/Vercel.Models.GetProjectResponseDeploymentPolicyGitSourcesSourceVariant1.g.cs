
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="org"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1(
            global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider provider,
            string org)
        {
            this.Provider = provider;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1" /> class.
        /// </summary>
        public GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1()
        {
        }

    }
}
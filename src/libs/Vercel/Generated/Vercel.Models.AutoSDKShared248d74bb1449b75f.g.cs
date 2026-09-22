
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Composable deployment-time policy. Each rule type holds a list of rules, one per environment scope.
    /// </summary>
    public sealed partial class AutoSDKShared248d74bb1449b75f
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared248d74bb1449b75fGitSourcesVariant1Item>, string>))]
        public global::Vercel.AnyOf<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared248d74bb1449b75fGitSourcesVariant1Item>, string>? GitSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1Item>, string>))]
        public global::Vercel.AnyOf<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1Item>, string>? DeploymentSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared248d74bb1449b75f" /> class.
        /// </summary>
        /// <param name="gitSources"></param>
        /// <param name="deploymentSources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared248d74bb1449b75f(
            global::Vercel.AnyOf<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared248d74bb1449b75fGitSourcesVariant1Item>, string>? gitSources,
            global::Vercel.AnyOf<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1Item>, string>? deploymentSources)
        {
            this.GitSources = gitSources;
            this.DeploymentSources = deploymentSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared248d74bb1449b75f" /> class.
        /// </summary>
        public AutoSDKShared248d74bb1449b75f()
        {
        }

    }
}
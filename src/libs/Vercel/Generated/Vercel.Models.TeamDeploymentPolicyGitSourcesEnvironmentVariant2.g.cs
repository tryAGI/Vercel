
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamDeploymentPolicyGitSourcesEnvironmentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamDeploymentPolicyGitSourcesEnvironmentVariant2TypeJsonConverter))]
        public global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicyGitSourcesEnvironmentVariant2" /> class.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDeploymentPolicyGitSourcesEnvironmentVariant2(
            string environmentId,
            global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type type)
        {
            this.Type = type;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicyGitSourcesEnvironmentVariant2" /> class.
        /// </summary>
        public TeamDeploymentPolicyGitSourcesEnvironmentVariant2()
        {
        }

    }
}
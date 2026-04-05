
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant167
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant167GitProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant167GitProvider GitProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepositoryName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRepositoryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant167" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="gitProvider"></param>
        /// <param name="gitRepoId"></param>
        /// <param name="gitRepositoryName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant167(
            string projectId,
            string projectName,
            global::Vercel.UserEventPayloadVariant167GitProvider gitProvider,
            string gitRepoId,
            string gitRepositoryName)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.GitProvider = gitProvider;
            this.GitRepoId = gitRepoId ?? throw new global::System.ArgumentNullException(nameof(gitRepoId));
            this.GitRepositoryName = gitRepositoryName ?? throw new global::System.ArgumentNullException(nameof(gitRepositoryName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant167" /> class.
        /// </summary>
        public UserEventPayloadVariant167()
        {
        }
    }
}
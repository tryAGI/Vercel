
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant170Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant170PreviousGitProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant170PreviousGitProvider GitProvider { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant170Previous" /> class.
        /// </summary>
        /// <param name="gitProvider"></param>
        /// <param name="gitRepoId"></param>
        /// <param name="gitRepositoryName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant170Previous(
            global::Vercel.UserEventPayloadVariant170PreviousGitProvider gitProvider,
            string gitRepoId,
            string gitRepositoryName)
        {
            this.GitProvider = gitProvider;
            this.GitRepoId = gitRepoId ?? throw new global::System.ArgumentNullException(nameof(gitRepoId));
            this.GitRepositoryName = gitRepositoryName ?? throw new global::System.ArgumentNullException(nameof(gitRepositoryName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant170Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant170Previous()
        {
        }
    }
}
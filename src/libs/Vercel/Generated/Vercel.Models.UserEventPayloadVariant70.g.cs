
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant70
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserPlatform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUserPlatform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitCommitterName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitterName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant70" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="gitUserPlatform"></param>
        /// <param name="projectName"></param>
        /// <param name="gitCommitterName"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant70(
            string sha,
            string gitUserPlatform,
            string projectName,
            string gitCommitterName,
            string source)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.GitUserPlatform = gitUserPlatform ?? throw new global::System.ArgumentNullException(nameof(gitUserPlatform));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.GitCommitterName = gitCommitterName ?? throw new global::System.ArgumentNullException(nameof(gitCommitterName));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant70" /> class.
        /// </summary>
        public UserEventPayloadVariant70()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditProjectEnvRequest
    {
        /// <summary>
        /// The name of the environment variable<br/>
        /// Example: GITHUB_APP_ID
        /// </summary>
        /// <example>GITHUB_APP_ID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The target environment of the environment variable<br/>
        /// Example: [preview]
        /// </summary>
        /// <example>[preview]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::System.Collections.Generic.IList<global::Vercel.EditProjectEnvRequestTargetItem>? Target { get; set; }

        /// <summary>
        /// If defined, the git branch of the environment variable (must have target=preview)<br/>
        /// Example: feature-1
        /// </summary>
        /// <example>feature-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// The type of environment variable<br/>
        /// Example: plain
        /// </summary>
        /// <example>plain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EditProjectEnvRequestTypeJsonConverter))]
        public global::Vercel.EditProjectEnvRequestType? Type { get; set; }

        /// <summary>
        /// The value of the environment variable<br/>
        /// Example: bkWIjbnxcvo78
        /// </summary>
        /// <example>bkWIjbnxcvo78</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The custom environments that the environment variable should be synced to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentIds")]
        public global::System.Collections.Generic.IList<string>? CustomEnvironmentIds { get; set; }

        /// <summary>
        /// A comment to add context on what this env var is for<br/>
        /// Example: database connection string for production
        /// </summary>
        /// <example>database connection string for production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditProjectEnvRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// The name of the environment variable<br/>
        /// Example: GITHUB_APP_ID
        /// </param>
        /// <param name="target">
        /// The target environment of the environment variable<br/>
        /// Example: [preview]
        /// </param>
        /// <param name="gitBranch">
        /// If defined, the git branch of the environment variable (must have target=preview)<br/>
        /// Example: feature-1
        /// </param>
        /// <param name="type">
        /// The type of environment variable<br/>
        /// Example: plain
        /// </param>
        /// <param name="value">
        /// The value of the environment variable<br/>
        /// Example: bkWIjbnxcvo78
        /// </param>
        /// <param name="customEnvironmentIds">
        /// The custom environments that the environment variable should be synced to
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this env var is for<br/>
        /// Example: database connection string for production
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditProjectEnvRequest(
            string? key,
            global::System.Collections.Generic.IList<global::Vercel.EditProjectEnvRequestTargetItem>? target,
            string? gitBranch,
            global::Vercel.EditProjectEnvRequestType? type,
            string? value,
            global::System.Collections.Generic.IList<string>? customEnvironmentIds,
            string? comment)
        {
            this.Key = key;
            this.Target = target;
            this.GitBranch = gitBranch;
            this.Type = type;
            this.Value = value;
            this.CustomEnvironmentIds = customEnvironmentIds;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditProjectEnvRequest" /> class.
        /// </summary>
        public EditProjectEnvRequest()
        {
        }
    }
}
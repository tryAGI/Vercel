
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectEnvRequestItem
    {
        /// <summary>
        /// The name of the environment variable<br/>
        /// Example: API_URL
        /// </summary>
        /// <example>API_URL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value of the environment variable<br/>
        /// Example: https://api.vercel.com
        /// </summary>
        /// <example>https://api.vercel.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The type of environment variable<br/>
        /// Example: plain
        /// </summary>
        /// <example>plain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectEnvRequestItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectEnvRequestItemType Type { get; set; }

        /// <summary>
        /// The target environment of the environment variable<br/>
        /// Example: [preview]
        /// </summary>
        /// <example>[preview]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvRequestItemTargetItem>? Target { get; set; }

        /// <summary>
        /// If defined, the git branch of the environment variable (must have target=preview)<br/>
        /// Example: feature-1
        /// </summary>
        /// <example>feature-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// A comment to add context on what this environment variable is for<br/>
        /// Example: database connection string for production
        /// </summary>
        /// <example>database connection string for production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The custom environment IDs associated with the environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentIds")]
        public global::System.Collections.Generic.IList<string>? CustomEnvironmentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectEnvRequestItem" /> class.
        /// </summary>
        /// <param name="key">
        /// The name of the environment variable<br/>
        /// Example: API_URL
        /// </param>
        /// <param name="value">
        /// The value of the environment variable<br/>
        /// Example: https://api.vercel.com
        /// </param>
        /// <param name="type">
        /// The type of environment variable<br/>
        /// Example: plain
        /// </param>
        /// <param name="target">
        /// The target environment of the environment variable<br/>
        /// Example: [preview]
        /// </param>
        /// <param name="gitBranch">
        /// If defined, the git branch of the environment variable (must have target=preview)<br/>
        /// Example: feature-1
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this environment variable is for<br/>
        /// Example: database connection string for production
        /// </param>
        /// <param name="customEnvironmentIds">
        /// The custom environment IDs associated with the environment variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectEnvRequestItem(
            string key,
            string value,
            global::Vercel.CreateProjectEnvRequestItemType type,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvRequestItemTargetItem>? target,
            string? gitBranch,
            string? comment,
            global::System.Collections.Generic.IList<string>? customEnvironmentIds)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.Target = target;
            this.GitBranch = gitBranch;
            this.Comment = comment;
            this.CustomEnvironmentIds = customEnvironmentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectEnvRequestItem" /> class.
        /// </summary>
        public CreateProjectEnvRequestItem()
        {
        }
    }
}
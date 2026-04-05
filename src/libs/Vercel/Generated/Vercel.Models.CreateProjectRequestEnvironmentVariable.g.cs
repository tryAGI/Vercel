
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectRequestEnvironmentVariable
    {
        /// <summary>
        /// Name of the ENV variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Deployment Target or Targets in which the ENV variable will be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateProjectRequestEnvironmentVariableTarget?, global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestEnvironmentVariableTargetItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CreateProjectRequestEnvironmentVariableTarget?, global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestEnvironmentVariableTargetItem>> Target { get; set; }

        /// <summary>
        /// If defined, the git branch of the environment variable (must have target=preview)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// Type of the ENV variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectRequestEnvironmentVariableTypeJsonConverter))]
        public global::Vercel.CreateProjectRequestEnvironmentVariableType? Type { get; set; }

        /// <summary>
        /// Value for the ENV variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="key">
        /// Name of the ENV variable
        /// </param>
        /// <param name="target">
        /// Deployment Target or Targets in which the ENV variable will be used
        /// </param>
        /// <param name="value">
        /// Value for the ENV variable
        /// </param>
        /// <param name="gitBranch">
        /// If defined, the git branch of the environment variable (must have target=preview)
        /// </param>
        /// <param name="type">
        /// Type of the ENV variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequestEnvironmentVariable(
            string key,
            global::Vercel.OneOf<global::Vercel.CreateProjectRequestEnvironmentVariableTarget?, global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestEnvironmentVariableTargetItem>> target,
            string value,
            string? gitBranch,
            global::Vercel.CreateProjectRequestEnvironmentVariableType? type)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Target = target;
            this.GitBranch = gitBranch;
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestEnvironmentVariable" /> class.
        /// </summary>
        public CreateProjectRequestEnvironmentVariable()
        {
        }
    }
}
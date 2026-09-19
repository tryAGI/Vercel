
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteSharedEnvVariableResponseFailedItemError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVarId")]
        public string? EnvVarId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVarKey")]
        public string? EnvVarKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorTargetItem>, global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorTarget?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorTargetItem>, global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorTarget?>? Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSharedEnvVariableResponseFailedItemError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="action"></param>
        /// <param name="envVarId"></param>
        /// <param name="envVarKey"></param>
        /// <param name="gitBranch"></param>
        /// <param name="key"></param>
        /// <param name="link"></param>
        /// <param name="project"></param>
        /// <param name="target"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSharedEnvVariableResponseFailedItemError(
            string code,
            string message,
            string? action,
            string? envVarId,
            string? envVarKey,
            string? gitBranch,
            string? key,
            string? link,
            string? project,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorTargetItem>, global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorTarget?>? target,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<global::Vercel.DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item>>? value)
        {
            this.Action = action;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.EnvVarId = envVarId;
            this.EnvVarKey = envVarKey;
            this.GitBranch = gitBranch;
            this.Key = key;
            this.Link = link;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Project = project;
            this.Target = target;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSharedEnvVariableResponseFailedItemError" /> class.
        /// </summary>
        public DeleteSharedEnvVariableResponseFailedItemError()
        {
        }

    }
}
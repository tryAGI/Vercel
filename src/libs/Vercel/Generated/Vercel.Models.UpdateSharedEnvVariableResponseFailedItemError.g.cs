
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableResponseFailedItemError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item>>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorTargetItem>, global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorTarget?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorTargetItem>, global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorTarget?>? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableResponseFailedItemError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="key"></param>
        /// <param name="envVarId"></param>
        /// <param name="envVarKey"></param>
        /// <param name="action"></param>
        /// <param name="link"></param>
        /// <param name="value"></param>
        /// <param name="gitBranch"></param>
        /// <param name="target"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSharedEnvVariableResponseFailedItemError(
            string code,
            string message,
            string? key,
            string? envVarId,
            string? envVarKey,
            string? action,
            string? link,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item>>? value,
            string? gitBranch,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorTargetItem>, global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorTarget?>? target,
            string? project)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Key = key;
            this.EnvVarId = envVarId;
            this.EnvVarKey = envVarKey;
            this.Action = action;
            this.Link = link;
            this.Value = value;
            this.GitBranch = gitBranch;
            this.Target = target;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableResponseFailedItemError" /> class.
        /// </summary>
        public UpdateSharedEnvVariableResponseFailedItemError()
        {
        }
    }
}
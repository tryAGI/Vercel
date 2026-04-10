
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant69JobVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventful")]
        public bool? Eventful { get; set; }

        /// <summary>
        /// GitLab
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant69JobVariant7HeadInfo HeadInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedProjectId")]
        public string? LinkedProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PrId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant69JobVariant7Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvId")]
        public string? CustomEnvId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant69JobVariant7TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant69JobVariant7Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.UserEventPayloadVariant69JobVariant7GitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant69JobVariant7ProviderJsonConverter))]
        public global::Vercel.UserEventPayloadVariant69JobVariant7Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant7" /> class.
        /// </summary>
        /// <param name="headInfo">
        /// GitLab
        /// </param>
        /// <param name="prId"></param>
        /// <param name="project"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="createdAt"></param>
        /// <param name="eventful"></param>
        /// <param name="linkedProjectId"></param>
        /// <param name="projectId"></param>
        /// <param name="customEnvId"></param>
        /// <param name="type"></param>
        /// <param name="gitComments"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant69JobVariant7(
            global::Vercel.UserEventPayloadVariant69JobVariant7HeadInfo headInfo,
            double prId,
            global::Vercel.UserEventPayloadVariant69JobVariant7Project project,
            string @ref,
            string sha,
            double? createdAt,
            bool? eventful,
            string? linkedProjectId,
            string? projectId,
            string? customEnvId,
            global::Vercel.UserEventPayloadVariant69JobVariant7Type type,
            global::Vercel.UserEventPayloadVariant69JobVariant7GitComments? gitComments,
            global::Vercel.UserEventPayloadVariant69JobVariant7Provider provider)
        {
            this.CreatedAt = createdAt;
            this.Eventful = eventful;
            this.HeadInfo = headInfo ?? throw new global::System.ArgumentNullException(nameof(headInfo));
            this.LinkedProjectId = linkedProjectId;
            this.PrId = prId;
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ProjectId = projectId;
            this.CustomEnvId = customEnvId;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Type = type;
            this.GitComments = gitComments;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant7" /> class.
        /// </summary>
        public UserEventPayloadVariant69JobVariant7()
        {
        }
    }
}
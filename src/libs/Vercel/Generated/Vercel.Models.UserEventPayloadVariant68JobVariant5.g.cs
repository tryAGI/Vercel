
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant68JobVariant5
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
        /// Information about the head commit/branch for a GitHub repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant5HeadInfo HeadInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeSha")]
        public string? BeforeSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPrivate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPrivate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedProjectId")]
        public string? LinkedProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PrId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public object? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvId")]
        public object? CustomEnvId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant5TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant68JobVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.UserEventPayloadVariant68JobVariant5GitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant5ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant5Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customHost")]
        public string? CustomHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant5" /> class.
        /// </summary>
        /// <param name="headInfo">
        /// Information about the head commit/branch for a GitHub repository
        /// </param>
        /// <param name="installationId"></param>
        /// <param name="isPrivate"></param>
        /// <param name="org"></param>
        /// <param name="prId"></param>
        /// <param name="repo"></param>
        /// <param name="repoId"></param>
        /// <param name="provider"></param>
        /// <param name="createdAt"></param>
        /// <param name="eventful"></param>
        /// <param name="beforeSha"></param>
        /// <param name="linkedProjectId"></param>
        /// <param name="projectId"></param>
        /// <param name="customEnvId"></param>
        /// <param name="type"></param>
        /// <param name="gitComments"></param>
        /// <param name="customHost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant68JobVariant5(
            global::Vercel.UserEventPayloadVariant68JobVariant5HeadInfo headInfo,
            double installationId,
            bool isPrivate,
            string org,
            double prId,
            string repo,
            double repoId,
            global::Vercel.UserEventPayloadVariant68JobVariant5Provider provider,
            double? createdAt,
            bool? eventful,
            string? beforeSha,
            string? linkedProjectId,
            object? projectId,
            object? customEnvId,
            global::Vercel.UserEventPayloadVariant68JobVariant5Type type,
            global::Vercel.UserEventPayloadVariant68JobVariant5GitComments? gitComments,
            string? customHost)
        {
            this.CreatedAt = createdAt;
            this.Eventful = eventful;
            this.HeadInfo = headInfo ?? throw new global::System.ArgumentNullException(nameof(headInfo));
            this.BeforeSha = beforeSha;
            this.InstallationId = installationId;
            this.IsPrivate = isPrivate;
            this.LinkedProjectId = linkedProjectId;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.PrId = prId;
            this.ProjectId = projectId;
            this.CustomEnvId = customEnvId;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.RepoId = repoId;
            this.Type = type;
            this.GitComments = gitComments;
            this.Provider = provider;
            this.CustomHost = customHost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant5" /> class.
        /// </summary>
        public UserEventPayloadVariant68JobVariant5()
        {
        }
    }
}
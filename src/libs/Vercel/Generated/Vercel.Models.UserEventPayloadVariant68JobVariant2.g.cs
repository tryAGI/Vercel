
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Represents the payload for a Bitbucket comment job This interface defines the structure of data needed when creating a job to handle comments on Bitbucket pull requests or commits.
    /// </summary>
    public sealed partial class UserEventPayloadVariant68JobVariant2
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant2HeadInfo HeadInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedProjectId")]
        public string? LinkedProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant2TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant68JobVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.UserEventPayloadVariant68JobVariant2GitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant2ProviderJsonConverter))]
        public global::Vercel.UserEventPayloadVariant68JobVariant2Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant2" /> class.
        /// </summary>
        /// <param name="headInfo"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="prId"></param>
        /// <param name="ref"></param>
        /// <param name="repoUuid"></param>
        /// <param name="sha"></param>
        /// <param name="slug"></param>
        /// <param name="workspaceUuid"></param>
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
        public UserEventPayloadVariant68JobVariant2(
            global::Vercel.UserEventPayloadVariant68JobVariant2HeadInfo headInfo,
            string name,
            string owner,
            double prId,
            string @ref,
            string repoUuid,
            string sha,
            string slug,
            string workspaceUuid,
            double? createdAt,
            bool? eventful,
            string? linkedProjectId,
            string? projectId,
            string? customEnvId,
            global::Vercel.UserEventPayloadVariant68JobVariant2Type type,
            global::Vercel.UserEventPayloadVariant68JobVariant2GitComments? gitComments,
            global::Vercel.UserEventPayloadVariant68JobVariant2Provider provider)
        {
            this.CreatedAt = createdAt;
            this.Eventful = eventful;
            this.HeadInfo = headInfo ?? throw new global::System.ArgumentNullException(nameof(headInfo));
            this.LinkedProjectId = linkedProjectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.PrId = prId;
            this.ProjectId = projectId;
            this.CustomEnvId = customEnvId;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RepoUuid = repoUuid ?? throw new global::System.ArgumentNullException(nameof(repoUuid));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Type = type;
            this.WorkspaceUuid = workspaceUuid ?? throw new global::System.ArgumentNullException(nameof(workspaceUuid));
            this.GitComments = gitComments;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant2" /> class.
        /// </summary>
        public UserEventPayloadVariant68JobVariant2()
        {
        }
    }
}
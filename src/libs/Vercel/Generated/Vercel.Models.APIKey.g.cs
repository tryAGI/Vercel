
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information about the newly created API key.
    /// </summary>
    public sealed partial class APIKey
    {
        /// <summary>
        /// The unique identifier of the API key.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </summary>
        /// <example>5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The human-readable name of the API key.<br/>
        /// Example: API Key for AI Gateway
        /// </summary>
        /// <example>API Key for AI Gateway</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The last few characters of the API key string, for helping identify the API key.<br/>
        /// Example: t7V
        /// </summary>
        /// <example>t7V</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("partialKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialKey { get; set; }

        /// <summary>
        /// The ID of the team that the API key grants access to.<br/>
        /// Example: team_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>team_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The API key's purpose, i.e. what resources it can be used with.<br/>
        /// Example: ai-gateway
        /// </summary>
        /// <example>ai-gateway</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// The ID of the project that this API key grants access to.<br/>
        /// When this is unset, the API key grants access to all projects in the team.<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </summary>
        /// <example>prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the API key expires.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the API key was most recently used.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveAt { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the API key was created.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The ID of the user who created the API key.<br/>
        /// Example: ZspSRT4ljIEEmMHgoDwKWDei
        /// </summary>
        /// <example>ZspSRT4ljIEEmMHgoDwKWDei</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the API key was marked as leaked.<br/>
        /// Example: 1632816536002L
        /// </summary>
        /// <example>1632816536002L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("leakedAt")]
        public double? LeakedAt { get; set; }

        /// <summary>
        /// URL where the API key was discovered as leaked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leakedUrl")]
        public string? LeakedUrl { get; set; }

        /// <summary>
        /// The ID of the app that created the API key, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdByAppId")]
        public string? CreatedByAppId { get; set; }

        /// <summary>
        /// AI Gateway quota associated with an API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        public global::Vercel.APIKeyQuota? Quota { get; set; }

        /// <summary>
        /// Generic metadata attached to the API key.<br/>
        /// The accepted shape depends on the key's `purpose` and is validated when the key is created. For `ai-gateway` keys this carries `environment` and `spendAttribution`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the API key.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </param>
        /// <param name="name">
        /// The human-readable name of the API key.<br/>
        /// Example: API Key for AI Gateway
        /// </param>
        /// <param name="partialKey">
        /// The last few characters of the API key string, for helping identify the API key.<br/>
        /// Example: t7V
        /// </param>
        /// <param name="teamId">
        /// The ID of the team that the API key grants access to.<br/>
        /// Example: team_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="purpose">
        /// The API key's purpose, i.e. what resources it can be used with.<br/>
        /// Example: ai-gateway
        /// </param>
        /// <param name="activeAt">
        /// Timestamp (in milliseconds) of when the API key was most recently used.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="createdAt">
        /// Timestamp (in milliseconds) of when the API key was created.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="createdBy">
        /// The ID of the user who created the API key.<br/>
        /// Example: ZspSRT4ljIEEmMHgoDwKWDei
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that this API key grants access to.<br/>
        /// When this is unset, the API key grants access to all projects in the team.<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="expiresAt">
        /// Timestamp (in milliseconds) of when the API key expires.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="leakedAt">
        /// Timestamp (in milliseconds) of when the API key was marked as leaked.<br/>
        /// Example: 1632816536002L
        /// </param>
        /// <param name="leakedUrl">
        /// URL where the API key was discovered as leaked.
        /// </param>
        /// <param name="createdByAppId">
        /// The ID of the app that created the API key, if any
        /// </param>
        /// <param name="quota">
        /// AI Gateway quota associated with an API key.
        /// </param>
        /// <param name="metadata">
        /// Generic metadata attached to the API key.<br/>
        /// The accepted shape depends on the key's `purpose` and is validated when the key is created. For `ai-gateway` keys this carries `environment` and `spendAttribution`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKey(
            string id,
            string name,
            string partialKey,
            string teamId,
            string purpose,
            double activeAt,
            double createdAt,
            string createdBy,
            string? projectId,
            double? expiresAt,
            double? leakedAt,
            string? leakedUrl,
            string? createdByAppId,
            global::Vercel.APIKeyQuota? quota,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PartialKey = partialKey ?? throw new global::System.ArgumentNullException(nameof(partialKey));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.ProjectId = projectId;
            this.ExpiresAt = expiresAt;
            this.ActiveAt = activeAt;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.LeakedAt = leakedAt;
            this.LeakedUrl = leakedUrl;
            this.CreatedByAppId = createdByAppId;
            this.Quota = quota;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKey" /> class.
        /// </summary>
        public APIKey()
        {
        }

    }
}
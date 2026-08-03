
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A team's access grant to a Vercel Container Registry repository.
    /// </summary>
    public sealed partial class VcrRepositoryPermission
    {
        /// <summary>
        /// Identifier of the repository the permission grants access to.<br/>
        /// Example: repo_a1b2c3d4e5f6
        /// </summary>
        /// <example>repo_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryId { get; set; }

        /// <summary>
        /// Identifier of the team that is granted access to the repository.<br/>
        /// Example: team_a1b2c3d4e5f6
        /// </summary>
        /// <example>team_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Slug of the team that is granted access to the repository.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamSlug { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the permission was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </summary>
        /// <example>2026-06-30T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepositoryPermission" /> class.
        /// </summary>
        /// <param name="repositoryId">
        /// Identifier of the repository the permission grants access to.<br/>
        /// Example: repo_a1b2c3d4e5f6
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team that is granted access to the repository.<br/>
        /// Example: team_a1b2c3d4e5f6
        /// </param>
        /// <param name="teamSlug">
        /// Slug of the team that is granted access to the repository.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the permission was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrRepositoryPermission(
            string repositoryId,
            string teamId,
            string teamSlug,
            string createdAt)
        {
            this.RepositoryId = repositoryId ?? throw new global::System.ArgumentNullException(nameof(repositoryId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamSlug = teamSlug ?? throw new global::System.ArgumentNullException(nameof(teamSlug));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepositoryPermission" /> class.
        /// </summary>
        public VcrRepositoryPermission()
        {
        }

    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// A Vercel Container Registry repository.
    /// </summary>
    public sealed partial class VcrRepository
    {
        /// <summary>
        /// Unique identifier of the repository.<br/>
        /// Example: repo_a1b2c3d4e5f6
        /// </summary>
        /// <example>repo_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the project the repository belongs to.<br/>
        /// Example: prj_a1b2c3d4e5f6
        /// </summary>
        /// <example>prj_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Name of the repository.<br/>
        /// Example: my-app
        /// </summary>
        /// <example>my-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the repository is public. Images in public repositories can be pulled by anyone. Defaults to `false` (private).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the repository was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </summary>
        /// <example>2026-06-30T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the repository was last updated.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </summary>
        /// <example>2026-06-30T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepository" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the repository.<br/>
        /// Example: repo_a1b2c3d4e5f6
        /// </param>
        /// <param name="projectId">
        /// Identifier of the project the repository belongs to.<br/>
        /// Example: prj_a1b2c3d4e5f6
        /// </param>
        /// <param name="name">
        /// Name of the repository.<br/>
        /// Example: my-app
        /// </param>
        /// <param name="public">
        /// Whether the repository is public. Images in public repositories can be pulled by anyone. Defaults to `false` (private).<br/>
        /// Example: false
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the repository was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the repository was last updated.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrRepository(
            string id,
            string projectId,
            string name,
            bool @public,
            string createdAt,
            string updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Public = @public;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepository" /> class.
        /// </summary>
        public VcrRepository()
        {
        }

    }
}
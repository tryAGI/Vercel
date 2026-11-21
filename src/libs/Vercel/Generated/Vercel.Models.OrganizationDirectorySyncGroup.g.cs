
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A group from the organization's Identity Provider directory, joined with its Directory Sync group configuration when one exists.
    /// </summary>
    public sealed partial class OrganizationDirectorySyncGroup
    {
        /// <summary>
        /// `null` when the group has no Directory Sync group configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::Vercel.OrganizationDirectorySyncGroupAssignments? Assignments { get; set; }

        /// <summary>
        /// `null` when the group has no Directory Sync group configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryGroupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryId { get; set; }

        /// <summary>
        /// The group's name in the Identity Provider directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// `null` when the group has no Directory Sync group configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDirectorySyncGroup" /> class.
        /// </summary>
        /// <param name="directoryGroupId"></param>
        /// <param name="directoryId"></param>
        /// <param name="name">
        /// The group's name in the Identity Provider directory.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="assignments">
        /// `null` when the group has no Directory Sync group configuration.
        /// </param>
        /// <param name="createdAt">
        /// `null` when the group has no Directory Sync group configuration.
        /// </param>
        /// <param name="updatedAt">
        /// `null` when the group has no Directory Sync group configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationDirectorySyncGroup(
            string directoryGroupId,
            string directoryId,
            string name,
            string organizationId,
            global::Vercel.OrganizationDirectorySyncGroupAssignments? assignments,
            string? createdAt,
            string? updatedAt)
        {
            this.Assignments = assignments;
            this.CreatedAt = createdAt;
            this.DirectoryGroupId = directoryGroupId ?? throw new global::System.ArgumentNullException(nameof(directoryGroupId));
            this.DirectoryId = directoryId ?? throw new global::System.ArgumentNullException(nameof(directoryId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDirectorySyncGroup" /> class.
        /// </summary>
        public OrganizationDirectorySyncGroup()
        {
        }

    }
}
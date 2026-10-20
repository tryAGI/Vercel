
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The organization's display name. Optional: organizations created before the name attribute existed have no stored value. New orgs always get one (provided or slug-derived) via the service layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TeamCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// The authenticated user's role in the organization. Present on read endpoints when the user holds an organization role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userRole")]
        public string? UserRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="organizationId"></param>
        /// <param name="slug"></param>
        /// <param name="teamCount"></param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="avatar"></param>
        /// <param name="name">
        /// The organization's display name. Optional: organizations created before the name attribute existed have no stored value. New orgs always get one (provided or slug-derived) via the service layer.
        /// </param>
        /// <param name="userRole">
        /// The authenticated user's role in the organization. Present on read endpoints when the user holds an organization role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            string createdAt,
            string organizationId,
            string slug,
            double teamCount,
            string teamId,
            string updatedAt,
            string? avatar,
            string? name,
            string? userRole)
        {
            this.Avatar = avatar;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Name = name;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.TeamCount = teamCount;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.UserRole = userRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }

    }
}
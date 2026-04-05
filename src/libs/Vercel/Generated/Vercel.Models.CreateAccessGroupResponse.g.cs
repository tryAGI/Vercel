
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAccessGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupResponseEntitlement> Entitlements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membersCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MembersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProjectsCount { get; set; }

        /// <summary>
        /// The name of this access group.<br/>
        /// Example: my-access-group
        /// </summary>
        /// <example>my-access-group</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Timestamp in milliseconds when the access group was created.<br/>
        /// Example: 1588720733602L
        /// </summary>
        /// <example>1588720733602L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ID of the team that this access group belongs to.<br/>
        /// Example: team_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>team_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Timestamp in milliseconds when the access group was last updated.<br/>
        /// Example: 1588720733602L
        /// </summary>
        /// <example>1588720733602L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// ID of the access group.<br/>
        /// Example: ag_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>ag_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGroupId { get; set; }

        /// <summary>
        /// Roles that the team has in the access group.<br/>
        /// Example: [DEVELOPER, BILLING]
        /// </summary>
        /// <example>[DEVELOPER, BILLING]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<string>? TeamRoles { get; set; }

        /// <summary>
        /// Permissions that the team has in the access group.<br/>
        /// Example: [CreateProject]
        /// </summary>
        /// <example>[CreateProject]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<string>? TeamPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessGroupResponse" /> class.
        /// </summary>
        /// <param name="entitlements"></param>
        /// <param name="membersCount"></param>
        /// <param name="projectsCount"></param>
        /// <param name="name">
        /// The name of this access group.<br/>
        /// Example: my-access-group
        /// </param>
        /// <param name="createdAt">
        /// Timestamp in milliseconds when the access group was created.<br/>
        /// Example: 1588720733602L
        /// </param>
        /// <param name="teamId">
        /// ID of the team that this access group belongs to.<br/>
        /// Example: team_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp in milliseconds when the access group was last updated.<br/>
        /// Example: 1588720733602L
        /// </param>
        /// <param name="accessGroupId">
        /// ID of the access group.<br/>
        /// Example: ag_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="teamRoles">
        /// Roles that the team has in the access group.<br/>
        /// Example: [DEVELOPER, BILLING]
        /// </param>
        /// <param name="teamPermissions">
        /// Permissions that the team has in the access group.<br/>
        /// Example: [CreateProject]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessGroupResponse(
            global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupResponseEntitlement> entitlements,
            double membersCount,
            double projectsCount,
            string name,
            string createdAt,
            string teamId,
            string updatedAt,
            string accessGroupId,
            global::System.Collections.Generic.IList<string>? teamRoles,
            global::System.Collections.Generic.IList<string>? teamPermissions)
        {
            this.Entitlements = entitlements ?? throw new global::System.ArgumentNullException(nameof(entitlements));
            this.MembersCount = membersCount;
            this.ProjectsCount = projectsCount;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.AccessGroupId = accessGroupId ?? throw new global::System.ArgumentNullException(nameof(accessGroupId));
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessGroupResponse" /> class.
        /// </summary>
        public CreateAccessGroupResponse()
        {
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectMembersResponseVariant2Member
    {
        /// <summary>
        /// ID of the file for the Avatar of this member.<br/>
        /// Example: 123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The email of this member.<br/>
        /// Example: jane.doe@example.com
        /// </summary>
        /// <example>jane.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Role of this user in the project.<br/>
        /// Example: ADMIN
        /// </summary>
        /// <example>ADMIN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectMembersResponseVariant2MemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectMembersResponseVariant2MemberRole Role { get; set; }

        /// <summary>
        /// Role of this user in the project.<br/>
        /// Example: ADMIN
        /// </summary>
        /// <example>ADMIN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("computedProjectRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectMembersResponseVariant2MemberComputedProjectRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectMembersResponseVariant2MemberComputedProjectRole ComputedProjectRole { get; set; }

        /// <summary>
        /// The ID of this user.<br/>
        /// Example: zTuNVUXEAvvnNN3IaqinkyMw
        /// </summary>
        /// <example>zTuNVUXEAvvnNN3IaqinkyMw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The unique username of this user.<br/>
        /// Example: jane-doe
        /// </summary>
        /// <example>jane-doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// The name of this user.<br/>
        /// Example: Jane Doe
        /// </summary>
        /// <example>Jane Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Timestamp in milliseconds when this member was added.<br/>
        /// Example: 1588720733602L
        /// </summary>
        /// <example>1588720733602L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The role of this user in the team.<br/>
        /// Example: CONTRIBUTOR
        /// </summary>
        /// <example>CONTRIBUTOR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectMembersResponseVariant2MemberTeamRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectMembersResponseVariant2MemberTeamRole TeamRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponseVariant2Member" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of this member.<br/>
        /// Example: jane.doe@example.com
        /// </param>
        /// <param name="role">
        /// Role of this user in the project.<br/>
        /// Example: ADMIN
        /// </param>
        /// <param name="computedProjectRole">
        /// Role of this user in the project.<br/>
        /// Example: ADMIN
        /// </param>
        /// <param name="uid">
        /// The ID of this user.<br/>
        /// Example: zTuNVUXEAvvnNN3IaqinkyMw
        /// </param>
        /// <param name="username">
        /// The unique username of this user.<br/>
        /// Example: jane-doe
        /// </param>
        /// <param name="createdAt">
        /// Timestamp in milliseconds when this member was added.<br/>
        /// Example: 1588720733602L
        /// </param>
        /// <param name="teamRole">
        /// The role of this user in the team.<br/>
        /// Example: CONTRIBUTOR
        /// </param>
        /// <param name="avatar">
        /// ID of the file for the Avatar of this member.<br/>
        /// Example: 123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="name">
        /// The name of this user.<br/>
        /// Example: Jane Doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectMembersResponseVariant2Member(
            string email,
            global::Vercel.GetProjectMembersResponseVariant2MemberRole role,
            global::Vercel.GetProjectMembersResponseVariant2MemberComputedProjectRole computedProjectRole,
            string uid,
            string username,
            double createdAt,
            global::Vercel.GetProjectMembersResponseVariant2MemberTeamRole teamRole,
            string? avatar,
            string? name)
        {
            this.Avatar = avatar;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.ComputedProjectRole = computedProjectRole;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Name = name;
            this.CreatedAt = createdAt;
            this.TeamRole = teamRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponseVariant2Member" /> class.
        /// </summary>
        public GetProjectMembersResponseVariant2Member()
        {
        }
    }
}
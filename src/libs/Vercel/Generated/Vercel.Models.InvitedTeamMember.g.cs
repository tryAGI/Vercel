
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The member was successfully added to the team.
    /// </summary>
    public sealed partial class InvitedTeamMember
    {
        /// <summary>
        /// The ID of the invited user<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </summary>
        /// <example>kr1PsOIzqEL5Xg6M4VZcZosf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The username of the invited user<br/>
        /// Example: john-doe
        /// </summary>
        /// <example>john-doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// The email of the invited user.<br/>
        /// Example: john@user.co
        /// </summary>
        /// <example>john@user.co</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The role used for the invitation<br/>
        /// Example: MEMBER
        /// </summary>
        /// <example>MEMBER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.InvitedTeamMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.InvitedTeamMemberRole Role { get; set; }

        /// <summary>
        /// The team roles of the user<br/>
        /// Example: [MEMBER]
        /// </summary>
        /// <example>[MEMBER]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.InvitedTeamMemberTeamRole>? TeamRoles { get; set; }

        /// <summary>
        /// The team permissions of the user<br/>
        /// Example: [CreateProject]
        /// </summary>
        /// <example>[CreateProject]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.InvitedTeamMemberTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvitedTeamMember" /> class.
        /// </summary>
        /// <param name="uid">
        /// The ID of the invited user<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </param>
        /// <param name="username">
        /// The username of the invited user<br/>
        /// Example: john-doe
        /// </param>
        /// <param name="email">
        /// The email of the invited user.<br/>
        /// Example: john@user.co
        /// </param>
        /// <param name="role">
        /// The role used for the invitation<br/>
        /// Example: MEMBER
        /// </param>
        /// <param name="teamRoles">
        /// The team roles of the user<br/>
        /// Example: [MEMBER]
        /// </param>
        /// <param name="teamPermissions">
        /// The team permissions of the user<br/>
        /// Example: [CreateProject]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvitedTeamMember(
            string uid,
            string username,
            string email,
            global::Vercel.InvitedTeamMemberRole role,
            global::System.Collections.Generic.IList<global::Vercel.InvitedTeamMemberTeamRole>? teamRoles,
            global::System.Collections.Generic.IList<global::Vercel.InvitedTeamMemberTeamPermission>? teamPermissions)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvitedTeamMember" /> class.
        /// </summary>
        public InvitedTeamMember()
        {
        }
    }
}
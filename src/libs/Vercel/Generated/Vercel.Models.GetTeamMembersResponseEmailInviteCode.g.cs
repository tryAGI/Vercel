
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTeamMembersResponseEmailInviteCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroups")]
        public global::System.Collections.Generic.IList<string>? AccessGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetTeamMembersResponseEmailInviteCodeRoleJsonConverter))]
        public global::Vercel.GetTeamMembersResponseEmailInviteCodeRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseEmailInviteCodeTeamRole>? TeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseEmailInviteCodeTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDSyncUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDSyncUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetTeamMembersResponseEmailInviteCodeProjects2>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.IList<string>? Entitlements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponseEmailInviteCode" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDSyncUser"></param>
        /// <param name="accessGroups"></param>
        /// <param name="email"></param>
        /// <param name="role"></param>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="createdAt"></param>
        /// <param name="expired"></param>
        /// <param name="projects"></param>
        /// <param name="entitlements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamMembersResponseEmailInviteCode(
            string id,
            bool isDSyncUser,
            global::System.Collections.Generic.IList<string>? accessGroups,
            string? email,
            global::Vercel.GetTeamMembersResponseEmailInviteCodeRole? role,
            global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseEmailInviteCodeTeamRole>? teamRoles,
            global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseEmailInviteCodeTeamPermission>? teamPermissions,
            double? createdAt,
            bool? expired,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetTeamMembersResponseEmailInviteCodeProjects2>? projects,
            global::System.Collections.Generic.IList<string>? entitlements)
        {
            this.AccessGroups = accessGroups;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email;
            this.Role = role;
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
            this.IsDSyncUser = isDSyncUser;
            this.CreatedAt = createdAt;
            this.Expired = expired;
            this.Projects = projects;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponseEmailInviteCode" /> class.
        /// </summary>
        public GetTeamMembersResponseEmailInviteCode()
        {
        }
    }
}
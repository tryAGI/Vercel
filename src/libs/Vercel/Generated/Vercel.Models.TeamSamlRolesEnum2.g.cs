
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When "Directory Sync" is configured, this object contains a mapping of which Directory Group (by ID) should be assigned to which Vercel Team roles and permissions, or an access group. Bare team roles are deprecated in favor of DirectorySyncRolesMapping.
    /// </summary>
    public sealed partial class TeamSamlRolesEnum2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamSamlRolesEnumTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.TeamSamlRolesEnumTeamRole> TeamRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSamlRolesEnum2" /> class.
        /// </summary>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamSamlRolesEnum2(
            global::System.Collections.Generic.IList<global::Vercel.TeamSamlRolesEnumTeamRole> teamRoles,
            global::System.Collections.Generic.IList<global::Vercel.TeamSamlRolesEnumTeamPermission>? teamPermissions)
        {
            this.TeamPermissions = teamPermissions;
            this.TeamRoles = teamRoles ?? throw new global::System.ArgumentNullException(nameof(teamRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSamlRolesEnum2" /> class.
        /// </summary>
        public TeamSamlRolesEnum2()
        {
        }

    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default roles for the team.
    /// </summary>
    public sealed partial class TeamDefaultRoles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamDefaultRolesTeamRole>? TeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamDefaultRolesTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultRoles" /> class.
        /// </summary>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDefaultRoles(
            global::System.Collections.Generic.IList<global::Vercel.TeamDefaultRolesTeamRole>? teamRoles,
            global::System.Collections.Generic.IList<global::Vercel.TeamDefaultRolesTeamPermission>? teamPermissions)
        {
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultRoles" /> class.
        /// </summary>
        public TeamDefaultRoles()
        {
        }
    }
}
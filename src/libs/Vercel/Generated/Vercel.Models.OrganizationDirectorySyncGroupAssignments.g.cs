
#nullable enable

namespace Vercel
{
    /// <summary>
    /// `null` when the group has no Directory Sync group configuration.
    /// </summary>
    public sealed partial class OrganizationDirectorySyncGroupAssignments
    {
        /// <summary>
        /// Organization-level permissions assigned to the directory group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationPermissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroupAssignmentsOrganizationPermission> OrganizationPermissions { get; set; }

        /// <summary>
        /// Roles for linked child teams without an explicit team assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroupAssignmentsTeamRole> TeamRoles { get; set; }

        /// <summary>
        /// Replaces the default team roles for each specified child team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.OrganizationDirectorySyncGroupAssignmentsTeams2> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDirectorySyncGroupAssignments" /> class.
        /// </summary>
        /// <param name="organizationPermissions">
        /// Organization-level permissions assigned to the directory group.
        /// </param>
        /// <param name="teamRoles">
        /// Roles for linked child teams without an explicit team assignment.
        /// </param>
        /// <param name="teams">
        /// Replaces the default team roles for each specified child team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationDirectorySyncGroupAssignments(
            global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroupAssignmentsOrganizationPermission> organizationPermissions,
            global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroupAssignmentsTeamRole> teamRoles,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.OrganizationDirectorySyncGroupAssignmentsTeams2> teams)
        {
            this.OrganizationPermissions = organizationPermissions ?? throw new global::System.ArgumentNullException(nameof(organizationPermissions));
            this.TeamRoles = teamRoles ?? throw new global::System.ArgumentNullException(nameof(teamRoles));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDirectorySyncGroupAssignments" /> class.
        /// </summary>
        public OrganizationDirectorySyncGroupAssignments()
        {
        }

    }
}
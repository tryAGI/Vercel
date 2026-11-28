
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Replaces the default team roles for each specified child team.
    /// </summary>
    public sealed partial class OrganizationDirectorySyncGroupAssignmentsTeams2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole> TeamRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDirectorySyncGroupAssignmentsTeams2" /> class.
        /// </summary>
        /// <param name="teamRoles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationDirectorySyncGroupAssignmentsTeams2(
            global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole> teamRoles)
        {
            this.TeamRoles = teamRoles ?? throw new global::System.ArgumentNullException(nameof(teamRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDirectorySyncGroupAssignmentsTeams2" /> class.
        /// </summary>
        public OrganizationDirectorySyncGroupAssignmentsTeams2()
        {
        }

    }
}
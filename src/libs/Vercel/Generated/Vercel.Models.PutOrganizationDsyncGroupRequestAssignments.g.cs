
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutOrganizationDsyncGroupRequestAssignments
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission>? OrganizationPermissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamRole>? TeamRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeams2>? Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationDsyncGroupRequestAssignments" /> class.
        /// </summary>
        /// <param name="organizationPermissions"></param>
        /// <param name="teamRoles"></param>
        /// <param name="teams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationDsyncGroupRequestAssignments(
            global::System.Collections.Generic.IList<global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission>? organizationPermissions,
            global::System.Collections.Generic.IList<global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamRole>? teamRoles,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeams2>? teams)
        {
            this.OrganizationPermissions = organizationPermissions;
            this.TeamRoles = teamRoles;
            this.Teams = teams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationDsyncGroupRequestAssignments" /> class.
        /// </summary>
        public PutOrganizationDsyncGroupRequestAssignments()
        {
        }

    }
}
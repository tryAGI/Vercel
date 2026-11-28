
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole
    {
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        Contributor,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Owner,
        /// <summary>
        ///
        /// </summary>
        Security,
        /// <summary>
        ///
        /// </summary>
        Viewer,
        /// <summary>
        ///
        /// </summary>
        ViewerForPlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole value)
        {
            return value switch
            {
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Billing => "BILLING",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Contributor => "CONTRIBUTOR",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Developer => "DEVELOPER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Member => "MEMBER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Owner => "OWNER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Security => "SECURITY",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Viewer => "VIEWER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Billing,
                "CONTRIBUTOR" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Contributor,
                "DEVELOPER" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Developer,
                "MEMBER" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Member,
                "OWNER" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Owner,
                "SECURITY" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Security,
                "VIEWER" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
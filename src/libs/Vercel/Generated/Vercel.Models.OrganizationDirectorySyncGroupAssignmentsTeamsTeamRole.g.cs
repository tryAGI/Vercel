
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole
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
    public static class OrganizationDirectorySyncGroupAssignmentsTeamsTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole value)
        {
            return value switch
            {
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Billing => "BILLING",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Contributor => "CONTRIBUTOR",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Developer => "DEVELOPER",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Member => "MEMBER",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Owner => "OWNER",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Security => "SECURITY",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Viewer => "VIEWER",
                OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Billing,
                "CONTRIBUTOR" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Contributor,
                "DEVELOPER" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Developer,
                "MEMBER" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Member,
                "OWNER" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Owner,
                "SECURITY" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Security,
                "VIEWER" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => OrganizationDirectorySyncGroupAssignmentsTeamsTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
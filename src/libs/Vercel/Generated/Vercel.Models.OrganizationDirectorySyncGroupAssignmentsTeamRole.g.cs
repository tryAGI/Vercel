
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Roles for linked child teams without an explicit team assignment.
    /// </summary>
    public enum OrganizationDirectorySyncGroupAssignmentsTeamRole
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
    public static class OrganizationDirectorySyncGroupAssignmentsTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDirectorySyncGroupAssignmentsTeamRole value)
        {
            return value switch
            {
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Billing => "BILLING",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Contributor => "CONTRIBUTOR",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Developer => "DEVELOPER",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Member => "MEMBER",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Owner => "OWNER",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Security => "SECURITY",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.Viewer => "VIEWER",
                OrganizationDirectorySyncGroupAssignmentsTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDirectorySyncGroupAssignmentsTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Billing,
                "CONTRIBUTOR" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Contributor,
                "DEVELOPER" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Developer,
                "MEMBER" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Member,
                "OWNER" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Owner,
                "SECURITY" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Security,
                "VIEWER" => OrganizationDirectorySyncGroupAssignmentsTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => OrganizationDirectorySyncGroupAssignmentsTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutOrganizationDsyncGroupRequestAssignmentsTeamRole
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
    public static class PutOrganizationDsyncGroupRequestAssignmentsTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationDsyncGroupRequestAssignmentsTeamRole value)
        {
            return value switch
            {
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Billing => "BILLING",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Contributor => "CONTRIBUTOR",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Developer => "DEVELOPER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Member => "MEMBER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Owner => "OWNER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Security => "SECURITY",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Viewer => "VIEWER",
                PutOrganizationDsyncGroupRequestAssignmentsTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationDsyncGroupRequestAssignmentsTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Billing,
                "CONTRIBUTOR" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Contributor,
                "DEVELOPER" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Developer,
                "MEMBER" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Member,
                "OWNER" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Owner,
                "SECURITY" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Security,
                "VIEWER" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => PutOrganizationDsyncGroupRequestAssignmentsTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
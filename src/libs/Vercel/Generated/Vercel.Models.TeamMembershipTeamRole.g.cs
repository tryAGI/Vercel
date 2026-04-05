
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamMembershipTeamRole
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
    public static class TeamMembershipTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMembershipTeamRole value)
        {
            return value switch
            {
                TeamMembershipTeamRole.Billing => "BILLING",
                TeamMembershipTeamRole.Contributor => "CONTRIBUTOR",
                TeamMembershipTeamRole.Developer => "DEVELOPER",
                TeamMembershipTeamRole.Member => "MEMBER",
                TeamMembershipTeamRole.Owner => "OWNER",
                TeamMembershipTeamRole.Security => "SECURITY",
                TeamMembershipTeamRole.Viewer => "VIEWER",
                TeamMembershipTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMembershipTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamMembershipTeamRole.Billing,
                "CONTRIBUTOR" => TeamMembershipTeamRole.Contributor,
                "DEVELOPER" => TeamMembershipTeamRole.Developer,
                "MEMBER" => TeamMembershipTeamRole.Member,
                "OWNER" => TeamMembershipTeamRole.Owner,
                "SECURITY" => TeamMembershipTeamRole.Security,
                "VIEWER" => TeamMembershipTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => TeamMembershipTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
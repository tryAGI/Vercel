
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamLimitedMembershipTeamRole
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
    public static class TeamLimitedMembershipTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedMembershipTeamRole value)
        {
            return value switch
            {
                TeamLimitedMembershipTeamRole.Billing => "BILLING",
                TeamLimitedMembershipTeamRole.Contributor => "CONTRIBUTOR",
                TeamLimitedMembershipTeamRole.Developer => "DEVELOPER",
                TeamLimitedMembershipTeamRole.Member => "MEMBER",
                TeamLimitedMembershipTeamRole.Owner => "OWNER",
                TeamLimitedMembershipTeamRole.Security => "SECURITY",
                TeamLimitedMembershipTeamRole.Viewer => "VIEWER",
                TeamLimitedMembershipTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamLimitedMembershipTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamLimitedMembershipTeamRole.Billing,
                "CONTRIBUTOR" => TeamLimitedMembershipTeamRole.Contributor,
                "DEVELOPER" => TeamLimitedMembershipTeamRole.Developer,
                "MEMBER" => TeamLimitedMembershipTeamRole.Member,
                "OWNER" => TeamLimitedMembershipTeamRole.Owner,
                "SECURITY" => TeamLimitedMembershipTeamRole.Security,
                "VIEWER" => TeamLimitedMembershipTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => TeamLimitedMembershipTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
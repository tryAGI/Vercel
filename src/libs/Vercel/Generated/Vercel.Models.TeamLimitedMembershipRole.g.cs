
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamLimitedMembershipRole
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
    public static class TeamLimitedMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedMembershipRole value)
        {
            return value switch
            {
                TeamLimitedMembershipRole.Billing => "BILLING",
                TeamLimitedMembershipRole.Contributor => "CONTRIBUTOR",
                TeamLimitedMembershipRole.Developer => "DEVELOPER",
                TeamLimitedMembershipRole.Member => "MEMBER",
                TeamLimitedMembershipRole.Owner => "OWNER",
                TeamLimitedMembershipRole.Security => "SECURITY",
                TeamLimitedMembershipRole.Viewer => "VIEWER",
                TeamLimitedMembershipRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamLimitedMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamLimitedMembershipRole.Billing,
                "CONTRIBUTOR" => TeamLimitedMembershipRole.Contributor,
                "DEVELOPER" => TeamLimitedMembershipRole.Developer,
                "MEMBER" => TeamLimitedMembershipRole.Member,
                "OWNER" => TeamLimitedMembershipRole.Owner,
                "SECURITY" => TeamLimitedMembershipRole.Security,
                "VIEWER" => TeamLimitedMembershipRole.Viewer,
                "VIEWER_FOR_PLUS" => TeamLimitedMembershipRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
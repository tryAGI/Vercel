
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamMembershipRole
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
    public static class TeamMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMembershipRole value)
        {
            return value switch
            {
                TeamMembershipRole.Billing => "BILLING",
                TeamMembershipRole.Contributor => "CONTRIBUTOR",
                TeamMembershipRole.Developer => "DEVELOPER",
                TeamMembershipRole.Member => "MEMBER",
                TeamMembershipRole.Owner => "OWNER",
                TeamMembershipRole.Security => "SECURITY",
                TeamMembershipRole.Viewer => "VIEWER",
                TeamMembershipRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamMembershipRole.Billing,
                "CONTRIBUTOR" => TeamMembershipRole.Contributor,
                "DEVELOPER" => TeamMembershipRole.Developer,
                "MEMBER" => TeamMembershipRole.Member,
                "OWNER" => TeamMembershipRole.Owner,
                "SECURITY" => TeamMembershipRole.Security,
                "VIEWER" => TeamMembershipRole.Viewer,
                "VIEWER_FOR_PLUS" => TeamMembershipRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
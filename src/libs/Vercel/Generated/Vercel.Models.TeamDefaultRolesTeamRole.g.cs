
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDefaultRolesTeamRole
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
    public static class TeamDefaultRolesTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDefaultRolesTeamRole value)
        {
            return value switch
            {
                TeamDefaultRolesTeamRole.Billing => "BILLING",
                TeamDefaultRolesTeamRole.Contributor => "CONTRIBUTOR",
                TeamDefaultRolesTeamRole.Developer => "DEVELOPER",
                TeamDefaultRolesTeamRole.Member => "MEMBER",
                TeamDefaultRolesTeamRole.Owner => "OWNER",
                TeamDefaultRolesTeamRole.Security => "SECURITY",
                TeamDefaultRolesTeamRole.Viewer => "VIEWER",
                TeamDefaultRolesTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDefaultRolesTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => TeamDefaultRolesTeamRole.Billing,
                "CONTRIBUTOR" => TeamDefaultRolesTeamRole.Contributor,
                "DEVELOPER" => TeamDefaultRolesTeamRole.Developer,
                "MEMBER" => TeamDefaultRolesTeamRole.Member,
                "OWNER" => TeamDefaultRolesTeamRole.Owner,
                "SECURITY" => TeamDefaultRolesTeamRole.Security,
                "VIEWER" => TeamDefaultRolesTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => TeamDefaultRolesTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
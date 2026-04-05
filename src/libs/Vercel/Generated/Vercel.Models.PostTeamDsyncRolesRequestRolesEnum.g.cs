
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostTeamDsyncRolesRequestRolesEnum
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
    public static class PostTeamDsyncRolesRequestRolesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostTeamDsyncRolesRequestRolesEnum value)
        {
            return value switch
            {
                PostTeamDsyncRolesRequestRolesEnum.Billing => "BILLING",
                PostTeamDsyncRolesRequestRolesEnum.Contributor => "CONTRIBUTOR",
                PostTeamDsyncRolesRequestRolesEnum.Developer => "DEVELOPER",
                PostTeamDsyncRolesRequestRolesEnum.Member => "MEMBER",
                PostTeamDsyncRolesRequestRolesEnum.Owner => "OWNER",
                PostTeamDsyncRolesRequestRolesEnum.Security => "SECURITY",
                PostTeamDsyncRolesRequestRolesEnum.Viewer => "VIEWER",
                PostTeamDsyncRolesRequestRolesEnum.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostTeamDsyncRolesRequestRolesEnum? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => PostTeamDsyncRolesRequestRolesEnum.Billing,
                "CONTRIBUTOR" => PostTeamDsyncRolesRequestRolesEnum.Contributor,
                "DEVELOPER" => PostTeamDsyncRolesRequestRolesEnum.Developer,
                "MEMBER" => PostTeamDsyncRolesRequestRolesEnum.Member,
                "OWNER" => PostTeamDsyncRolesRequestRolesEnum.Owner,
                "SECURITY" => PostTeamDsyncRolesRequestRolesEnum.Security,
                "VIEWER" => PostTeamDsyncRolesRequestRolesEnum.Viewer,
                "VIEWER_FOR_PLUS" => PostTeamDsyncRolesRequestRolesEnum.ViewerForPlus,
                _ => null,
            };
        }
    }
}
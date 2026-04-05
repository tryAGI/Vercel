
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Only return members with the specified team role.<br/>
    /// Example: OWNER
    /// </summary>
    public enum GetTeamMembersRole
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
    public static class GetTeamMembersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersRole value)
        {
            return value switch
            {
                GetTeamMembersRole.Billing => "BILLING",
                GetTeamMembersRole.Contributor => "CONTRIBUTOR",
                GetTeamMembersRole.Developer => "DEVELOPER",
                GetTeamMembersRole.Member => "MEMBER",
                GetTeamMembersRole.Owner => "OWNER",
                GetTeamMembersRole.Security => "SECURITY",
                GetTeamMembersRole.Viewer => "VIEWER",
                GetTeamMembersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => GetTeamMembersRole.Billing,
                "CONTRIBUTOR" => GetTeamMembersRole.Contributor,
                "DEVELOPER" => GetTeamMembersRole.Developer,
                "MEMBER" => GetTeamMembersRole.Member,
                "OWNER" => GetTeamMembersRole.Owner,
                "SECURITY" => GetTeamMembersRole.Security,
                "VIEWER" => GetTeamMembersRole.Viewer,
                "VIEWER_FOR_PLUS" => GetTeamMembersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
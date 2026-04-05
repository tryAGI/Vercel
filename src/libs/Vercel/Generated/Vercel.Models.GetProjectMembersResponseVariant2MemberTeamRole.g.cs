
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The role of this user in the team.<br/>
    /// Example: CONTRIBUTOR
    /// </summary>
    public enum GetProjectMembersResponseVariant2MemberTeamRole
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
    public static class GetProjectMembersResponseVariant2MemberTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectMembersResponseVariant2MemberTeamRole value)
        {
            return value switch
            {
                GetProjectMembersResponseVariant2MemberTeamRole.Billing => "BILLING",
                GetProjectMembersResponseVariant2MemberTeamRole.Contributor => "CONTRIBUTOR",
                GetProjectMembersResponseVariant2MemberTeamRole.Developer => "DEVELOPER",
                GetProjectMembersResponseVariant2MemberTeamRole.Member => "MEMBER",
                GetProjectMembersResponseVariant2MemberTeamRole.Owner => "OWNER",
                GetProjectMembersResponseVariant2MemberTeamRole.Security => "SECURITY",
                GetProjectMembersResponseVariant2MemberTeamRole.Viewer => "VIEWER",
                GetProjectMembersResponseVariant2MemberTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectMembersResponseVariant2MemberTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => GetProjectMembersResponseVariant2MemberTeamRole.Billing,
                "CONTRIBUTOR" => GetProjectMembersResponseVariant2MemberTeamRole.Contributor,
                "DEVELOPER" => GetProjectMembersResponseVariant2MemberTeamRole.Developer,
                "MEMBER" => GetProjectMembersResponseVariant2MemberTeamRole.Member,
                "OWNER" => GetProjectMembersResponseVariant2MemberTeamRole.Owner,
                "SECURITY" => GetProjectMembersResponseVariant2MemberTeamRole.Security,
                "VIEWER" => GetProjectMembersResponseVariant2MemberTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => GetProjectMembersResponseVariant2MemberTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
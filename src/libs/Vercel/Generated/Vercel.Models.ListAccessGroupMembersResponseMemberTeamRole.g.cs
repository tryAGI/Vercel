
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAccessGroupMembersResponseMemberTeamRole
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
    public static class ListAccessGroupMembersResponseMemberTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAccessGroupMembersResponseMemberTeamRole value)
        {
            return value switch
            {
                ListAccessGroupMembersResponseMemberTeamRole.Billing => "BILLING",
                ListAccessGroupMembersResponseMemberTeamRole.Contributor => "CONTRIBUTOR",
                ListAccessGroupMembersResponseMemberTeamRole.Developer => "DEVELOPER",
                ListAccessGroupMembersResponseMemberTeamRole.Member => "MEMBER",
                ListAccessGroupMembersResponseMemberTeamRole.Owner => "OWNER",
                ListAccessGroupMembersResponseMemberTeamRole.Security => "SECURITY",
                ListAccessGroupMembersResponseMemberTeamRole.Viewer => "VIEWER",
                ListAccessGroupMembersResponseMemberTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAccessGroupMembersResponseMemberTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => ListAccessGroupMembersResponseMemberTeamRole.Billing,
                "CONTRIBUTOR" => ListAccessGroupMembersResponseMemberTeamRole.Contributor,
                "DEVELOPER" => ListAccessGroupMembersResponseMemberTeamRole.Developer,
                "MEMBER" => ListAccessGroupMembersResponseMemberTeamRole.Member,
                "OWNER" => ListAccessGroupMembersResponseMemberTeamRole.Owner,
                "SECURITY" => ListAccessGroupMembersResponseMemberTeamRole.Security,
                "VIEWER" => ListAccessGroupMembersResponseMemberTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => ListAccessGroupMembersResponseMemberTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
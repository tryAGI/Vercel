
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Role of this user in the team.<br/>
    /// Example: OWNER
    /// </summary>
    public enum GetTeamMembersResponseMemberRole
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
    public static class GetTeamMembersResponseMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseMemberRole value)
        {
            return value switch
            {
                GetTeamMembersResponseMemberRole.Billing => "BILLING",
                GetTeamMembersResponseMemberRole.Contributor => "CONTRIBUTOR",
                GetTeamMembersResponseMemberRole.Developer => "DEVELOPER",
                GetTeamMembersResponseMemberRole.Member => "MEMBER",
                GetTeamMembersResponseMemberRole.Owner => "OWNER",
                GetTeamMembersResponseMemberRole.Security => "SECURITY",
                GetTeamMembersResponseMemberRole.Viewer => "VIEWER",
                GetTeamMembersResponseMemberRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => GetTeamMembersResponseMemberRole.Billing,
                "CONTRIBUTOR" => GetTeamMembersResponseMemberRole.Contributor,
                "DEVELOPER" => GetTeamMembersResponseMemberRole.Developer,
                "MEMBER" => GetTeamMembersResponseMemberRole.Member,
                "OWNER" => GetTeamMembersResponseMemberRole.Owner,
                "SECURITY" => GetTeamMembersResponseMemberRole.Security,
                "VIEWER" => GetTeamMembersResponseMemberRole.Viewer,
                "VIEWER_FOR_PLUS" => GetTeamMembersResponseMemberRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
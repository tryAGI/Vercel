
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamMembersResponseEmailInviteCodeRole
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
    public static class GetTeamMembersResponseEmailInviteCodeRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseEmailInviteCodeRole value)
        {
            return value switch
            {
                GetTeamMembersResponseEmailInviteCodeRole.Billing => "BILLING",
                GetTeamMembersResponseEmailInviteCodeRole.Contributor => "CONTRIBUTOR",
                GetTeamMembersResponseEmailInviteCodeRole.Developer => "DEVELOPER",
                GetTeamMembersResponseEmailInviteCodeRole.Member => "MEMBER",
                GetTeamMembersResponseEmailInviteCodeRole.Owner => "OWNER",
                GetTeamMembersResponseEmailInviteCodeRole.Security => "SECURITY",
                GetTeamMembersResponseEmailInviteCodeRole.Viewer => "VIEWER",
                GetTeamMembersResponseEmailInviteCodeRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseEmailInviteCodeRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => GetTeamMembersResponseEmailInviteCodeRole.Billing,
                "CONTRIBUTOR" => GetTeamMembersResponseEmailInviteCodeRole.Contributor,
                "DEVELOPER" => GetTeamMembersResponseEmailInviteCodeRole.Developer,
                "MEMBER" => GetTeamMembersResponseEmailInviteCodeRole.Member,
                "OWNER" => GetTeamMembersResponseEmailInviteCodeRole.Owner,
                "SECURITY" => GetTeamMembersResponseEmailInviteCodeRole.Security,
                "VIEWER" => GetTeamMembersResponseEmailInviteCodeRole.Viewer,
                "VIEWER_FOR_PLUS" => GetTeamMembersResponseEmailInviteCodeRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
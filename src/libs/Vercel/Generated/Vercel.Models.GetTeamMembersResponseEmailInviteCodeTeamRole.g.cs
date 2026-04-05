
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamMembersResponseEmailInviteCodeTeamRole
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
    public static class GetTeamMembersResponseEmailInviteCodeTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseEmailInviteCodeTeamRole value)
        {
            return value switch
            {
                GetTeamMembersResponseEmailInviteCodeTeamRole.Billing => "BILLING",
                GetTeamMembersResponseEmailInviteCodeTeamRole.Contributor => "CONTRIBUTOR",
                GetTeamMembersResponseEmailInviteCodeTeamRole.Developer => "DEVELOPER",
                GetTeamMembersResponseEmailInviteCodeTeamRole.Member => "MEMBER",
                GetTeamMembersResponseEmailInviteCodeTeamRole.Owner => "OWNER",
                GetTeamMembersResponseEmailInviteCodeTeamRole.Security => "SECURITY",
                GetTeamMembersResponseEmailInviteCodeTeamRole.Viewer => "VIEWER",
                GetTeamMembersResponseEmailInviteCodeTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseEmailInviteCodeTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => GetTeamMembersResponseEmailInviteCodeTeamRole.Billing,
                "CONTRIBUTOR" => GetTeamMembersResponseEmailInviteCodeTeamRole.Contributor,
                "DEVELOPER" => GetTeamMembersResponseEmailInviteCodeTeamRole.Developer,
                "MEMBER" => GetTeamMembersResponseEmailInviteCodeTeamRole.Member,
                "OWNER" => GetTeamMembersResponseEmailInviteCodeTeamRole.Owner,
                "SECURITY" => GetTeamMembersResponseEmailInviteCodeTeamRole.Security,
                "VIEWER" => GetTeamMembersResponseEmailInviteCodeTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => GetTeamMembersResponseEmailInviteCodeTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
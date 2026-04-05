
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The role used for the invitation<br/>
    /// Example: MEMBER
    /// </summary>
    public enum InvitedTeamMemberRole
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
    public static class InvitedTeamMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvitedTeamMemberRole value)
        {
            return value switch
            {
                InvitedTeamMemberRole.Billing => "BILLING",
                InvitedTeamMemberRole.Contributor => "CONTRIBUTOR",
                InvitedTeamMemberRole.Developer => "DEVELOPER",
                InvitedTeamMemberRole.Member => "MEMBER",
                InvitedTeamMemberRole.Owner => "OWNER",
                InvitedTeamMemberRole.Security => "SECURITY",
                InvitedTeamMemberRole.Viewer => "VIEWER",
                InvitedTeamMemberRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvitedTeamMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => InvitedTeamMemberRole.Billing,
                "CONTRIBUTOR" => InvitedTeamMemberRole.Contributor,
                "DEVELOPER" => InvitedTeamMemberRole.Developer,
                "MEMBER" => InvitedTeamMemberRole.Member,
                "OWNER" => InvitedTeamMemberRole.Owner,
                "SECURITY" => InvitedTeamMemberRole.Security,
                "VIEWER" => InvitedTeamMemberRole.Viewer,
                "VIEWER_FOR_PLUS" => InvitedTeamMemberRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
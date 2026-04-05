
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The team roles of the user<br/>
    /// Example: [MEMBER]
    /// </summary>
    public enum InvitedTeamMemberTeamRole
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
    public static class InvitedTeamMemberTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvitedTeamMemberTeamRole value)
        {
            return value switch
            {
                InvitedTeamMemberTeamRole.Billing => "BILLING",
                InvitedTeamMemberTeamRole.Contributor => "CONTRIBUTOR",
                InvitedTeamMemberTeamRole.Developer => "DEVELOPER",
                InvitedTeamMemberTeamRole.Member => "MEMBER",
                InvitedTeamMemberTeamRole.Owner => "OWNER",
                InvitedTeamMemberTeamRole.Security => "SECURITY",
                InvitedTeamMemberTeamRole.Viewer => "VIEWER",
                InvitedTeamMemberTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvitedTeamMemberTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => InvitedTeamMemberTeamRole.Billing,
                "CONTRIBUTOR" => InvitedTeamMemberTeamRole.Contributor,
                "DEVELOPER" => InvitedTeamMemberTeamRole.Developer,
                "MEMBER" => InvitedTeamMemberTeamRole.Member,
                "OWNER" => InvitedTeamMemberTeamRole.Owner,
                "SECURITY" => InvitedTeamMemberTeamRole.Security,
                "VIEWER" => InvitedTeamMemberTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => InvitedTeamMemberTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
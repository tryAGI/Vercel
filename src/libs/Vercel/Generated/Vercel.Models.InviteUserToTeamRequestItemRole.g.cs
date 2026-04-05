
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The role of the user to invite<br/>
    /// Default Value: VIEWER<br/>
    /// Example: VIEWER
    /// </summary>
    public enum InviteUserToTeamRequestItemRole
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
    public static class InviteUserToTeamRequestItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteUserToTeamRequestItemRole value)
        {
            return value switch
            {
                InviteUserToTeamRequestItemRole.Billing => "BILLING",
                InviteUserToTeamRequestItemRole.Contributor => "CONTRIBUTOR",
                InviteUserToTeamRequestItemRole.Developer => "DEVELOPER",
                InviteUserToTeamRequestItemRole.Member => "MEMBER",
                InviteUserToTeamRequestItemRole.Owner => "OWNER",
                InviteUserToTeamRequestItemRole.Security => "SECURITY",
                InviteUserToTeamRequestItemRole.Viewer => "VIEWER",
                InviteUserToTeamRequestItemRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteUserToTeamRequestItemRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => InviteUserToTeamRequestItemRole.Billing,
                "CONTRIBUTOR" => InviteUserToTeamRequestItemRole.Contributor,
                "DEVELOPER" => InviteUserToTeamRequestItemRole.Developer,
                "MEMBER" => InviteUserToTeamRequestItemRole.Member,
                "OWNER" => InviteUserToTeamRequestItemRole.Owner,
                "SECURITY" => InviteUserToTeamRequestItemRole.Security,
                "VIEWER" => InviteUserToTeamRequestItemRole.Viewer,
                "VIEWER_FOR_PLUS" => InviteUserToTeamRequestItemRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
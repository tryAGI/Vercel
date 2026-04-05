
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sets the project roles for the invited user<br/>
    /// Example: ADMIN
    /// </summary>
    public enum InviteUserToTeamRequestItemProjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeveloper,
        /// <summary>
        /// 
        /// </summary>
        ProjectGuest,
        /// <summary>
        /// 
        /// </summary>
        ProjectViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteUserToTeamRequestItemProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteUserToTeamRequestItemProjectRole value)
        {
            return value switch
            {
                InviteUserToTeamRequestItemProjectRole.Admin => "ADMIN",
                InviteUserToTeamRequestItemProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                InviteUserToTeamRequestItemProjectRole.ProjectGuest => "PROJECT_GUEST",
                InviteUserToTeamRequestItemProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteUserToTeamRequestItemProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => InviteUserToTeamRequestItemProjectRole.Admin,
                "PROJECT_DEVELOPER" => InviteUserToTeamRequestItemProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => InviteUserToTeamRequestItemProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => InviteUserToTeamRequestItemProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
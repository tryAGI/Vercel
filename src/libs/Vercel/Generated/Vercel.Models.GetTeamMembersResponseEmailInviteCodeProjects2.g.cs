
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamMembersResponseEmailInviteCodeProjects2
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
    public static class GetTeamMembersResponseEmailInviteCodeProjects2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseEmailInviteCodeProjects2 value)
        {
            return value switch
            {
                GetTeamMembersResponseEmailInviteCodeProjects2.Admin => "ADMIN",
                GetTeamMembersResponseEmailInviteCodeProjects2.ProjectDeveloper => "PROJECT_DEVELOPER",
                GetTeamMembersResponseEmailInviteCodeProjects2.ProjectGuest => "PROJECT_GUEST",
                GetTeamMembersResponseEmailInviteCodeProjects2.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseEmailInviteCodeProjects2? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => GetTeamMembersResponseEmailInviteCodeProjects2.Admin,
                "PROJECT_DEVELOPER" => GetTeamMembersResponseEmailInviteCodeProjects2.ProjectDeveloper,
                "PROJECT_GUEST" => GetTeamMembersResponseEmailInviteCodeProjects2.ProjectGuest,
                "PROJECT_VIEWER" => GetTeamMembersResponseEmailInviteCodeProjects2.ProjectViewer,
                _ => null,
            };
        }
    }
}
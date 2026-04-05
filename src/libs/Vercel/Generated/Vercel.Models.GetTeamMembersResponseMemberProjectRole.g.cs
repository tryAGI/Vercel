
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamMembersResponseMemberProjectRole
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
    public static class GetTeamMembersResponseMemberProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseMemberProjectRole value)
        {
            return value switch
            {
                GetTeamMembersResponseMemberProjectRole.Admin => "ADMIN",
                GetTeamMembersResponseMemberProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                GetTeamMembersResponseMemberProjectRole.ProjectGuest => "PROJECT_GUEST",
                GetTeamMembersResponseMemberProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseMemberProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => GetTeamMembersResponseMemberProjectRole.Admin,
                "PROJECT_DEVELOPER" => GetTeamMembersResponseMemberProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => GetTeamMembersResponseMemberProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => GetTeamMembersResponseMemberProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
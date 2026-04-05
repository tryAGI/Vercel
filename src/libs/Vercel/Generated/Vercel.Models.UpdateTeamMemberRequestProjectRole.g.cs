
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project role of the member that will be added. \"null\" will remove this project level role.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum UpdateTeamMemberRequestProjectRole
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
        ProjectViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTeamMemberRequestProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTeamMemberRequestProjectRole value)
        {
            return value switch
            {
                UpdateTeamMemberRequestProjectRole.Admin => "ADMIN",
                UpdateTeamMemberRequestProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UpdateTeamMemberRequestProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTeamMemberRequestProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UpdateTeamMemberRequestProjectRole.Admin,
                "PROJECT_DEVELOPER" => UpdateTeamMemberRequestProjectRole.ProjectDeveloper,
                "PROJECT_VIEWER" => UpdateTeamMemberRequestProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
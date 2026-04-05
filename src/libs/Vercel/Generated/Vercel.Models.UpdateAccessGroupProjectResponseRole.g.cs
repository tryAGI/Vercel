
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAccessGroupProjectResponseRole
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
    public static class UpdateAccessGroupProjectResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAccessGroupProjectResponseRole value)
        {
            return value switch
            {
                UpdateAccessGroupProjectResponseRole.Admin => "ADMIN",
                UpdateAccessGroupProjectResponseRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UpdateAccessGroupProjectResponseRole.ProjectGuest => "PROJECT_GUEST",
                UpdateAccessGroupProjectResponseRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAccessGroupProjectResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UpdateAccessGroupProjectResponseRole.Admin,
                "PROJECT_DEVELOPER" => UpdateAccessGroupProjectResponseRole.ProjectDeveloper,
                "PROJECT_GUEST" => UpdateAccessGroupProjectResponseRole.ProjectGuest,
                "PROJECT_VIEWER" => UpdateAccessGroupProjectResponseRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
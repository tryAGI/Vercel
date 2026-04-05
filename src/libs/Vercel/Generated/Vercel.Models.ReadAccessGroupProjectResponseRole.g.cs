
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReadAccessGroupProjectResponseRole
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
    public static class ReadAccessGroupProjectResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadAccessGroupProjectResponseRole value)
        {
            return value switch
            {
                ReadAccessGroupProjectResponseRole.Admin => "ADMIN",
                ReadAccessGroupProjectResponseRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                ReadAccessGroupProjectResponseRole.ProjectGuest => "PROJECT_GUEST",
                ReadAccessGroupProjectResponseRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadAccessGroupProjectResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => ReadAccessGroupProjectResponseRole.Admin,
                "PROJECT_DEVELOPER" => ReadAccessGroupProjectResponseRole.ProjectDeveloper,
                "PROJECT_GUEST" => ReadAccessGroupProjectResponseRole.ProjectGuest,
                "PROJECT_VIEWER" => ReadAccessGroupProjectResponseRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
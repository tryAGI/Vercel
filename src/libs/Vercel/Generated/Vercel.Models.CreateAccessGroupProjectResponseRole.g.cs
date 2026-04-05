
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAccessGroupProjectResponseRole
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
    public static class CreateAccessGroupProjectResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAccessGroupProjectResponseRole value)
        {
            return value switch
            {
                CreateAccessGroupProjectResponseRole.Admin => "ADMIN",
                CreateAccessGroupProjectResponseRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                CreateAccessGroupProjectResponseRole.ProjectGuest => "PROJECT_GUEST",
                CreateAccessGroupProjectResponseRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAccessGroupProjectResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => CreateAccessGroupProjectResponseRole.Admin,
                "PROJECT_DEVELOPER" => CreateAccessGroupProjectResponseRole.ProjectDeveloper,
                "PROJECT_GUEST" => CreateAccessGroupProjectResponseRole.ProjectGuest,
                "PROJECT_VIEWER" => CreateAccessGroupProjectResponseRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
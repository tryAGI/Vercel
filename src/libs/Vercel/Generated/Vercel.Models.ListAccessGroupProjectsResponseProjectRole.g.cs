
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAccessGroupProjectsResponseProjectRole
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
    public static class ListAccessGroupProjectsResponseProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAccessGroupProjectsResponseProjectRole value)
        {
            return value switch
            {
                ListAccessGroupProjectsResponseProjectRole.Admin => "ADMIN",
                ListAccessGroupProjectsResponseProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                ListAccessGroupProjectsResponseProjectRole.ProjectGuest => "PROJECT_GUEST",
                ListAccessGroupProjectsResponseProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAccessGroupProjectsResponseProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => ListAccessGroupProjectsResponseProjectRole.Admin,
                "PROJECT_DEVELOPER" => ListAccessGroupProjectsResponseProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => ListAccessGroupProjectsResponseProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => ListAccessGroupProjectsResponseProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project role that will be added to this Access Group. "null" will remove this project level role.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum UpdateAccessGroupRequestProjectRole
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
    public static class UpdateAccessGroupRequestProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAccessGroupRequestProjectRole value)
        {
            return value switch
            {
                UpdateAccessGroupRequestProjectRole.Admin => "ADMIN",
                UpdateAccessGroupRequestProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UpdateAccessGroupRequestProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAccessGroupRequestProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UpdateAccessGroupRequestProjectRole.Admin,
                "PROJECT_DEVELOPER" => UpdateAccessGroupRequestProjectRole.ProjectDeveloper,
                "PROJECT_VIEWER" => UpdateAccessGroupRequestProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
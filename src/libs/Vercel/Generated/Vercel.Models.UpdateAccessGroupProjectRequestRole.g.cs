
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project role that will be added to this Access Group.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum UpdateAccessGroupProjectRequestRole
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
    public static class UpdateAccessGroupProjectRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAccessGroupProjectRequestRole value)
        {
            return value switch
            {
                UpdateAccessGroupProjectRequestRole.Admin => "ADMIN",
                UpdateAccessGroupProjectRequestRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UpdateAccessGroupProjectRequestRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAccessGroupProjectRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UpdateAccessGroupProjectRequestRole.Admin,
                "PROJECT_DEVELOPER" => UpdateAccessGroupProjectRequestRole.ProjectDeveloper,
                "PROJECT_VIEWER" => UpdateAccessGroupProjectRequestRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
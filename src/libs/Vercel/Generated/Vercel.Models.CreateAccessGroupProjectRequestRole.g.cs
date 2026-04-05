
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project role that will be added to this Access Group.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum CreateAccessGroupProjectRequestRole
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
    public static class CreateAccessGroupProjectRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAccessGroupProjectRequestRole value)
        {
            return value switch
            {
                CreateAccessGroupProjectRequestRole.Admin => "ADMIN",
                CreateAccessGroupProjectRequestRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                CreateAccessGroupProjectRequestRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAccessGroupProjectRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => CreateAccessGroupProjectRequestRole.Admin,
                "PROJECT_DEVELOPER" => CreateAccessGroupProjectRequestRole.ProjectDeveloper,
                "PROJECT_VIEWER" => CreateAccessGroupProjectRequestRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
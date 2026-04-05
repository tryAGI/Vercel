
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project role that will be added to this Access Group. \"null\" will remove this project level role.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum CreateAccessGroupRequestProjectRole
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
    public static class CreateAccessGroupRequestProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAccessGroupRequestProjectRole value)
        {
            return value switch
            {
                CreateAccessGroupRequestProjectRole.Admin => "ADMIN",
                CreateAccessGroupRequestProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                CreateAccessGroupRequestProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAccessGroupRequestProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => CreateAccessGroupRequestProjectRole.Admin,
                "PROJECT_DEVELOPER" => CreateAccessGroupRequestProjectRole.ProjectDeveloper,
                "PROJECT_VIEWER" => CreateAccessGroupRequestProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
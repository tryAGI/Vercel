
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project role of the member that will be added.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum AddProjectMemberRequestRole
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
    public static class AddProjectMemberRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddProjectMemberRequestRole value)
        {
            return value switch
            {
                AddProjectMemberRequestRole.Admin => "ADMIN",
                AddProjectMemberRequestRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                AddProjectMemberRequestRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddProjectMemberRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => AddProjectMemberRequestRole.Admin,
                "PROJECT_DEVELOPER" => AddProjectMemberRequestRole.ProjectDeveloper,
                "PROJECT_VIEWER" => AddProjectMemberRequestRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
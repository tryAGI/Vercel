
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant204ProjectRole
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
    public static class UserEventPayloadVariant204ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant204ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant204ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant204ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant204ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant204ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant204ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant204ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant204ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant204ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant204ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
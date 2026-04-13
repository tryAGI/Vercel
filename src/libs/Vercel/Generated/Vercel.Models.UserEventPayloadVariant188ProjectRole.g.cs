
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant188ProjectRole
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
    public static class UserEventPayloadVariant188ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant188ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant188ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant188ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant188ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant188ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant188ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant188ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant188ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant188ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant188ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant180ProjectRole
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
    public static class UserEventPayloadVariant180ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant180ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant180ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant180ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant180ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant180ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant180ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant180ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant180ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant180ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant180ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
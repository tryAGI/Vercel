
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant181ProjectRole
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
    public static class UserEventPayloadVariant181ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant181ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant181ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant181ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant181ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant181ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant181ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant181ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant181ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant181ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant181ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
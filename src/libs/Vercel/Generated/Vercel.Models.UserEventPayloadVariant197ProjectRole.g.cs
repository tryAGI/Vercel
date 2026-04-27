
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant197ProjectRole
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
    public static class UserEventPayloadVariant197ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant197ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant197ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant197ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant197ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant197ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant197ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant197ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant197ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant197ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant197ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
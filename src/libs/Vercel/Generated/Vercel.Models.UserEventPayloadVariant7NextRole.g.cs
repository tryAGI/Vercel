
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant7NextRole
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
    public static class UserEventPayloadVariant7NextRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant7NextRole value)
        {
            return value switch
            {
                UserEventPayloadVariant7NextRole.Admin => "ADMIN",
                UserEventPayloadVariant7NextRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant7NextRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant7NextRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant7NextRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant7NextRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant7NextRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant7NextRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant7NextRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
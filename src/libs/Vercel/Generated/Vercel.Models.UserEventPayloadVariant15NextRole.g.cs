
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant15NextRole
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
    public static class UserEventPayloadVariant15NextRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant15NextRole value)
        {
            return value switch
            {
                UserEventPayloadVariant15NextRole.Admin => "ADMIN",
                UserEventPayloadVariant15NextRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant15NextRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant15NextRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant15NextRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant15NextRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant15NextRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant15NextRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant15NextRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
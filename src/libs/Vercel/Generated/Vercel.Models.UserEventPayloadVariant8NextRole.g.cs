
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant8NextRole
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
    public static class UserEventPayloadVariant8NextRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant8NextRole value)
        {
            return value switch
            {
                UserEventPayloadVariant8NextRole.Admin => "ADMIN",
                UserEventPayloadVariant8NextRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant8NextRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant8NextRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant8NextRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant8NextRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant8NextRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant8NextRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant8NextRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
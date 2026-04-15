
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant190ProjectRole
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
    public static class UserEventPayloadVariant190ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant190ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant190ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant190ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant190ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant190ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant190ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant190ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant190ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant190ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant190ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
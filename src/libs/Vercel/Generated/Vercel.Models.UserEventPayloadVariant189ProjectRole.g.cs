
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant189ProjectRole
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
    public static class UserEventPayloadVariant189ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant189ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant189ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant189ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant189ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant189ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant189ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant189ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant189ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant189ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant189ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
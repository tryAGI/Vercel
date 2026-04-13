
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant186ProjectRole
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
    public static class UserEventPayloadVariant186ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant186ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant186ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant186ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant186ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant186ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant186ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant186ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant186ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant186ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant186ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
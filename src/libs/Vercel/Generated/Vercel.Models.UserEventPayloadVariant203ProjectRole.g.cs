
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant203ProjectRole
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
    public static class UserEventPayloadVariant203ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant203ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant203ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant203ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant203ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant203ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant203ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant203ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant203ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant203ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant203ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
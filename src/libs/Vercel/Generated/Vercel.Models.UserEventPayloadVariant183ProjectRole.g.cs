
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant183ProjectRole
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
    public static class UserEventPayloadVariant183ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant183ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant183ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant183ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant183ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant183ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant183ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant183ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant183ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant183ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant183ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
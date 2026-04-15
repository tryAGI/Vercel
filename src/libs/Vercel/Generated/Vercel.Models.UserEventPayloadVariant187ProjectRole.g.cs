
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant187ProjectRole
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
    public static class UserEventPayloadVariant187ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant187ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant187ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant187ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant187ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant187ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant187ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant187ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant187ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant187ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant187ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
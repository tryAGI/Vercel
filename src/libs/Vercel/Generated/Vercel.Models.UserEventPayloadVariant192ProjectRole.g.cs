
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant192ProjectRole
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
    public static class UserEventPayloadVariant192ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant192ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant192ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant192ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant192ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant192ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant192ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant192ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant192ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant192ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant192ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
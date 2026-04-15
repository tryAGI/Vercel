
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant193ProjectRole
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
    public static class UserEventPayloadVariant193ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant193ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant193ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant193ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant193ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant193ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant193ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant193ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant193ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant193ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant193ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
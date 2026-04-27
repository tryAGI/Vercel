
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant194ProjectRole
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
    public static class UserEventPayloadVariant194ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant194ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant194ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant194ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant194ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant194ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant194ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant194ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant194ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant194ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant194ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant206ProjectRole
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
    public static class UserEventPayloadVariant206ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant206ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant206ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant206ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant206ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant206ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant206ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant206ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant206ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant206ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant206ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
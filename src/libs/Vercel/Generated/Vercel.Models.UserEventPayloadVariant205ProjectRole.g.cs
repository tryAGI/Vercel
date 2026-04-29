
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant205ProjectRole
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
    public static class UserEventPayloadVariant205ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant205ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant205ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant205ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant205ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant205ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant205ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant205ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant205ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant205ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant205ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
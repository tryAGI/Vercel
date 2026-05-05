
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant207ProjectRole
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
    public static class UserEventPayloadVariant207ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant207ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant207ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant207ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant207ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant207ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant207ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant207ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant207ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant207ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant207ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
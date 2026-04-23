
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant195ProjectRole
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
    public static class UserEventPayloadVariant195ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant195ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant195ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant195ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant195ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant195ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant195ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant195ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant195ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant195ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant195ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
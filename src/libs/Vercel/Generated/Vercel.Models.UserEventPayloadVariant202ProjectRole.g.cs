
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant202ProjectRole
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
    public static class UserEventPayloadVariant202ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant202ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant202ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant202ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant202ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant202ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant202ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant202ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant202ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant202ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant202ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
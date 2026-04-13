
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant9NextRole
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
    public static class UserEventPayloadVariant9NextRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant9NextRole value)
        {
            return value switch
            {
                UserEventPayloadVariant9NextRole.Admin => "ADMIN",
                UserEventPayloadVariant9NextRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant9NextRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant9NextRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant9NextRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant9NextRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant9NextRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant9NextRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant9NextRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
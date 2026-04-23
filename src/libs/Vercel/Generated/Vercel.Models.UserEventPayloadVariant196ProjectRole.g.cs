
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant196ProjectRole
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
    public static class UserEventPayloadVariant196ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant196ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant196ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant196ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant196ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant196ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant196ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant196ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant196ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant196ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant196ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
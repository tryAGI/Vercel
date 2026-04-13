
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant9PreviousRole
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
    public static class UserEventPayloadVariant9PreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant9PreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant9PreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant9PreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant9PreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant9PreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant9PreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant9PreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant9PreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant9PreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant9PreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
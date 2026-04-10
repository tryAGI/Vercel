
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant8PreviousRole
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
    public static class UserEventPayloadVariant8PreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant8PreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant8PreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant8PreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant8PreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant8PreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant8PreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant8PreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant8PreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant8PreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant8PreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
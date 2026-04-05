
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant7PreviousRole
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
    public static class UserEventPayloadVariant7PreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant7PreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant7PreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant7PreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant7PreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant7PreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant7PreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant7PreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant7PreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant7PreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant7PreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
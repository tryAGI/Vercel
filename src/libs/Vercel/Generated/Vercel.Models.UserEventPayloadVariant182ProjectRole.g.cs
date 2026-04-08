
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant182ProjectRole
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
    public static class UserEventPayloadVariant182ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant182ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant182ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant182ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant182ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant182ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant182ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant182ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant182ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant182ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant182ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
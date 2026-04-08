
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant185ProjectRole
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
    public static class UserEventPayloadVariant185ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant185ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant185ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant185ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant185ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant185ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant185ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant185ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant185ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant185ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant185ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
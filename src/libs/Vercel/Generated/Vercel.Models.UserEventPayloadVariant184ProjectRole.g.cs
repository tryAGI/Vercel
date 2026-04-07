
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant184ProjectRole
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
    public static class UserEventPayloadVariant184ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant184ProjectRole value)
        {
            return value switch
            {
                UserEventPayloadVariant184ProjectRole.Admin => "ADMIN",
                UserEventPayloadVariant184ProjectRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant184ProjectRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant184ProjectRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant184ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant184ProjectRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant184ProjectRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant184ProjectRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant184ProjectRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
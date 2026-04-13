
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant190ProjectMembershipRole
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
    public static class UserEventPayloadVariant190ProjectMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant190ProjectMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant190ProjectMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant190ProjectMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant190ProjectMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant190ProjectMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant190ProjectMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant190ProjectMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant190ProjectMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant190ProjectMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant190ProjectMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
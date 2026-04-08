
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant187ProjectMembershipRole
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
    public static class UserEventPayloadVariant187ProjectMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant187ProjectMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant187ProjectMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant187ProjectMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant187ProjectMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant187ProjectMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant187ProjectMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant187ProjectMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant187ProjectMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant187ProjectMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant187ProjectMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
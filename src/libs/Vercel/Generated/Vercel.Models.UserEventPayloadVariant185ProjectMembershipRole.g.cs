
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant185ProjectMembershipRole
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
    public static class UserEventPayloadVariant185ProjectMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant185ProjectMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant185ProjectMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant185ProjectMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant185ProjectMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant185ProjectMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant185ProjectMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant185ProjectMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant185ProjectMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant185ProjectMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant185ProjectMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
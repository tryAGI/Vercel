
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant202ProjectMembershipRole
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
    public static class UserEventPayloadVariant202ProjectMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant202ProjectMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant202ProjectMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant202ProjectMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant202ProjectMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant202ProjectMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant202ProjectMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant202ProjectMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant202ProjectMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant202ProjectMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant202ProjectMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
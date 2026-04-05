
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant182ProjectMembershipRole
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
    public static class UserEventPayloadVariant182ProjectMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant182ProjectMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant182ProjectMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant182ProjectMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant182ProjectMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant182ProjectMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant182ProjectMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant182ProjectMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant182ProjectMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant182ProjectMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant182ProjectMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
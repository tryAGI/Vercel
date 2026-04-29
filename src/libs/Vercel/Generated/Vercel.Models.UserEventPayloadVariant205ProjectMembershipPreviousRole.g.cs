
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant205ProjectMembershipPreviousRole
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
    public static class UserEventPayloadVariant205ProjectMembershipPreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant205ProjectMembershipPreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant205ProjectMembershipPreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant205ProjectMembershipPreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant205ProjectMembershipPreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant205ProjectMembershipPreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant205ProjectMembershipPreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant205ProjectMembershipPreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant205ProjectMembershipPreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant205ProjectMembershipPreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant205ProjectMembershipPreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
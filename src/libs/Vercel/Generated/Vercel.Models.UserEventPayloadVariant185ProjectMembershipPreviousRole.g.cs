
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant185ProjectMembershipPreviousRole
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
    public static class UserEventPayloadVariant185ProjectMembershipPreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant185ProjectMembershipPreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant185ProjectMembershipPreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant185ProjectMembershipPreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant185ProjectMembershipPreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant185ProjectMembershipPreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant185ProjectMembershipPreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant185ProjectMembershipPreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant185ProjectMembershipPreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant185ProjectMembershipPreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant185ProjectMembershipPreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
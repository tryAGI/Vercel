
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant198ProjectMembershipPreviousRole
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
    public static class UserEventPayloadVariant198ProjectMembershipPreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant198ProjectMembershipPreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant198ProjectMembershipPreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant198ProjectMembershipPreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant198ProjectMembershipPreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant198ProjectMembershipPreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant198ProjectMembershipPreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant198ProjectMembershipPreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant198ProjectMembershipPreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant198ProjectMembershipPreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant198ProjectMembershipPreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
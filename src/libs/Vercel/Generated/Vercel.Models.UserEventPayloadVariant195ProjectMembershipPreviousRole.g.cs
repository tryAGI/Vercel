
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant195ProjectMembershipPreviousRole
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
    public static class UserEventPayloadVariant195ProjectMembershipPreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant195ProjectMembershipPreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant195ProjectMembershipPreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant195ProjectMembershipPreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant195ProjectMembershipPreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant195ProjectMembershipPreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant195ProjectMembershipPreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant195ProjectMembershipPreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant195ProjectMembershipPreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant195ProjectMembershipPreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant195ProjectMembershipPreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
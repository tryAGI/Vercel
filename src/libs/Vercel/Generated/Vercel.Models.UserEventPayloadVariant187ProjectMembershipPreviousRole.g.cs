
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant187ProjectMembershipPreviousRole
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
    public static class UserEventPayloadVariant187ProjectMembershipPreviousRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant187ProjectMembershipPreviousRole value)
        {
            return value switch
            {
                UserEventPayloadVariant187ProjectMembershipPreviousRole.Admin => "ADMIN",
                UserEventPayloadVariant187ProjectMembershipPreviousRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant187ProjectMembershipPreviousRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant187ProjectMembershipPreviousRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant187ProjectMembershipPreviousRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant187ProjectMembershipPreviousRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant187ProjectMembershipPreviousRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant187ProjectMembershipPreviousRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant187ProjectMembershipPreviousRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant189RemovedMembershipRole
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
    public static class UserEventPayloadVariant189RemovedMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant189RemovedMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant189RemovedMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant189RemovedMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant189RemovedMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant189RemovedMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant189RemovedMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant189RemovedMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant189RemovedMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant189RemovedMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant189RemovedMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant198RemovedMembershipRole
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
    public static class UserEventPayloadVariant198RemovedMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant198RemovedMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant198RemovedMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant198RemovedMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant198RemovedMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant198RemovedMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant198RemovedMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant198RemovedMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant198RemovedMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant198RemovedMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant198RemovedMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
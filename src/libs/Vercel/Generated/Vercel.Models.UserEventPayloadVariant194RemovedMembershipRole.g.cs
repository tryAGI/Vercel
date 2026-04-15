
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant194RemovedMembershipRole
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
    public static class UserEventPayloadVariant194RemovedMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant194RemovedMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant194RemovedMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant194RemovedMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant194RemovedMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant194RemovedMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant194RemovedMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant194RemovedMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant194RemovedMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant194RemovedMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant194RemovedMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant204RemovedMembershipRole
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
    public static class UserEventPayloadVariant204RemovedMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant204RemovedMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant204RemovedMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant204RemovedMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant204RemovedMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant204RemovedMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant204RemovedMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant204RemovedMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant204RemovedMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant204RemovedMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant204RemovedMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant197RemovedMembershipRole
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
    public static class UserEventPayloadVariant197RemovedMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant197RemovedMembershipRole value)
        {
            return value switch
            {
                UserEventPayloadVariant197RemovedMembershipRole.Admin => "ADMIN",
                UserEventPayloadVariant197RemovedMembershipRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                UserEventPayloadVariant197RemovedMembershipRole.ProjectGuest => "PROJECT_GUEST",
                UserEventPayloadVariant197RemovedMembershipRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant197RemovedMembershipRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => UserEventPayloadVariant197RemovedMembershipRole.Admin,
                "PROJECT_DEVELOPER" => UserEventPayloadVariant197RemovedMembershipRole.ProjectDeveloper,
                "PROJECT_GUEST" => UserEventPayloadVariant197RemovedMembershipRole.ProjectGuest,
                "PROJECT_VIEWER" => UserEventPayloadVariant197RemovedMembershipRole.ProjectViewer,
                _ => null,
            };
        }
    }
}
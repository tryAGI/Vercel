
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant242RemovedUsersRole
    {
        /// <summary>
        /// 
        /// </summary>
        Billing,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Security,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
        /// <summary>
        /// 
        /// </summary>
        ViewerForPlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant242RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant242RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant242RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant242RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant242RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant242RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant242RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant242RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant242RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant242RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant242RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant242RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant242RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant242RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant242RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant242RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant242RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
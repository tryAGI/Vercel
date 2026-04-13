
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245RemovedUsersRole
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
    public static class UserEventPayloadVariant245RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant245RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant245RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant245RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant245RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant245RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant245RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant245RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant245RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant245RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant245RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant245RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant245RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant245RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant245RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant245RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant245RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
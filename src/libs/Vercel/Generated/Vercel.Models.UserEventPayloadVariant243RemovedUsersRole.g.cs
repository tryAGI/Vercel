
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant243RemovedUsersRole
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
    public static class UserEventPayloadVariant243RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant243RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant243RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant243RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant243RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant243RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant243RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant243RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant243RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant243RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant243RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant243RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant243RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant243RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant243RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant243RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant243RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
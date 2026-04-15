
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251RemovedUsersRole
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
    public static class UserEventPayloadVariant251RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant251RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant251RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant251RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant251RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant251RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant251RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant251RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant251RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant251RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant251RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant251RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant251RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant251RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant251RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant251RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant251RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
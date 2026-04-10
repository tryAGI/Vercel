
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant135RemovedUsersRole
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
    public static class UserEventPayloadVariant135RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant135RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant135RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant135RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant135RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant135RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant135RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant135RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant135RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant135RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant135RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant135RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant135RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant135RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant135RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant135RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant135RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant135RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant135RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
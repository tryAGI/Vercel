
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant151RemovedUsersRole
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
    public static class UserEventPayloadVariant151RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant151RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant151RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant151RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant151RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant151RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant151RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant151RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant151RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant151RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant151RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant151RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant151RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant151RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant151RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant151RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant151RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant151RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant151RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
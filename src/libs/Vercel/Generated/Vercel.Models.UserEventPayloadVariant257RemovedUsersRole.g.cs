
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant257RemovedUsersRole
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
    public static class UserEventPayloadVariant257RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant257RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant257RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant257RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant257RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant257RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant257RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant257RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant257RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant257RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant257RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant257RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant257RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant257RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant257RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant257RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant257RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant257RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant257RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
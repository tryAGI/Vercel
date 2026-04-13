
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant136RemovedUsersRole
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
    public static class UserEventPayloadVariant136RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant136RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant136RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant136RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant136RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant136RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant136RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant136RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant136RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant136RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant136RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant136RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant136RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant136RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant136RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant136RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant136RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant136RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant136RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
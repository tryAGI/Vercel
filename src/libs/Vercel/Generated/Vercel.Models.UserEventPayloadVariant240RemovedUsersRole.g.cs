
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant240RemovedUsersRole
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
    public static class UserEventPayloadVariant240RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant240RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant240RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant240RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant240RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant240RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant240RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant240RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant240RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant240RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant240RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant240RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant240RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant240RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant240RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant240RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant240RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252RemovedUsersRole
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
    public static class UserEventPayloadVariant252RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant252RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant252RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant252RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant252RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant252RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant252RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant252RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant252RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant252RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant252RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant252RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant252RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant252RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant252RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant252RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant252RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
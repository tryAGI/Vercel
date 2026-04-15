
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant139RemovedUsersRole
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
    public static class UserEventPayloadVariant139RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant139RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant139RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant139RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant139RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant139RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant139RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant139RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant139RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant139RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant139RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant139RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant139RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant139RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant139RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant139RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant139RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant139RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant139RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
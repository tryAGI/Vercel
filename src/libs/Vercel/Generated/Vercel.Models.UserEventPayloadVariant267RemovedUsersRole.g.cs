
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267RemovedUsersRole
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
    public static class UserEventPayloadVariant267RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant267RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant267RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant267RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant267RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant267RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant267RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant267RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant267RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant267RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant267RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant267RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant267RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant267RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant267RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant267RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant267RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
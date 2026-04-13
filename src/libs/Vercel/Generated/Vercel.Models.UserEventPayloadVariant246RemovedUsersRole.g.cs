
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246RemovedUsersRole
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
    public static class UserEventPayloadVariant246RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant246RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant246RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant246RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant246RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant246RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant246RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant246RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant246RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant246RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant246RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant246RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant246RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant246RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant246RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant246RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant246RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
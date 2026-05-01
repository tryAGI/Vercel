
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266RemovedUsersRole
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
    public static class UserEventPayloadVariant266RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant266RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant266RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant266RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant266RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant266RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant266RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant266RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant266RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant266RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant266RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant266RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant266RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant266RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant266RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant266RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant266RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
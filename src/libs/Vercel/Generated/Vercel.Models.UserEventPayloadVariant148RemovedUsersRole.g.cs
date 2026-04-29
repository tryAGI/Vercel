
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant148RemovedUsersRole
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
    public static class UserEventPayloadVariant148RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant148RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant148RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant148RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant148RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant148RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant148RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant148RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant148RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant148RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant148RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant148RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant148RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant148RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant148RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant148RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant148RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant148RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant148RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
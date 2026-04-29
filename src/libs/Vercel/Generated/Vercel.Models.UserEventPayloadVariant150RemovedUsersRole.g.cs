
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant150RemovedUsersRole
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
    public static class UserEventPayloadVariant150RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant150RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant150RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant150RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant150RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant150RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant150RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant150RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant150RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant150RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant150RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant150RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant150RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant150RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant150RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant150RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant150RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant150RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant150RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
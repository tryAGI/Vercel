
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant134RemovedUsersRole
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
    public static class UserEventPayloadVariant134RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant134RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant134RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant134RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant134RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant134RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant134RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant134RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant134RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant134RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant134RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant134RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant134RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant134RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant134RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant134RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant134RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant134RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant134RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
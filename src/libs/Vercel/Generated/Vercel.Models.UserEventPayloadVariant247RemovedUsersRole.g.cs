
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant247RemovedUsersRole
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
    public static class UserEventPayloadVariant247RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant247RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant247RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant247RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant247RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant247RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant247RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant247RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant247RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant247RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant247RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant247RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant247RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant247RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant247RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant247RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant247RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
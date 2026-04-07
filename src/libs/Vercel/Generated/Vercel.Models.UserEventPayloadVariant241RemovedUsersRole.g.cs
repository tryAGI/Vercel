
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant241RemovedUsersRole
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
    public static class UserEventPayloadVariant241RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant241RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant241RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant241RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant241RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant241RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant241RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant241RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant241RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant241RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant241RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant241RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant241RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant241RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant241RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant241RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant241RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
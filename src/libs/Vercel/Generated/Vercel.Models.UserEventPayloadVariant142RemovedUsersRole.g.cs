
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant142RemovedUsersRole
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
    public static class UserEventPayloadVariant142RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant142RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant142RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant142RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant142RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant142RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant142RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant142RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant142RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant142RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant142RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant142RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant142RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant142RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant142RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant142RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant142RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant142RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant142RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
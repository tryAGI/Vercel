
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256RemovedUsersRole
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
    public static class UserEventPayloadVariant256RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant256RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant256RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant256RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant256RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant256RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant256RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant256RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant256RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant256RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant256RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant256RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant256RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant256RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant256RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant256RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant256RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
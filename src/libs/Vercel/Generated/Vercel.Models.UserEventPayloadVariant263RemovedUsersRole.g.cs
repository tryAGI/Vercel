
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant263RemovedUsersRole
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
    public static class UserEventPayloadVariant263RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant263RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant263RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant263RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant263RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant263RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant263RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant263RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant263RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant263RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant263RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant263RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant263RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant263RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant263RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant263RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant263RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant263RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant263RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant253RemovedUsersRole
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
    public static class UserEventPayloadVariant253RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant253RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant253RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant253RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant253RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant253RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant253RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant253RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant253RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant253RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant253RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant253RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant253RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant253RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant253RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant253RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant253RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
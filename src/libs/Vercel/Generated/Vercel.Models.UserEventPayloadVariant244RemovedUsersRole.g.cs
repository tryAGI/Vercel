
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244RemovedUsersRole
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
    public static class UserEventPayloadVariant244RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant244RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant244RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant244RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant244RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant244RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant244RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant244RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant244RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant244RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant244RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant244RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant244RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant244RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant244RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant244RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant244RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
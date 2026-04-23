
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255RemovedUsersRole
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
    public static class UserEventPayloadVariant255RemovedUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255RemovedUsersRole value)
        {
            return value switch
            {
                UserEventPayloadVariant255RemovedUsersRole.Billing => "BILLING",
                UserEventPayloadVariant255RemovedUsersRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant255RemovedUsersRole.Developer => "DEVELOPER",
                UserEventPayloadVariant255RemovedUsersRole.Member => "MEMBER",
                UserEventPayloadVariant255RemovedUsersRole.Owner => "OWNER",
                UserEventPayloadVariant255RemovedUsersRole.Security => "SECURITY",
                UserEventPayloadVariant255RemovedUsersRole.Viewer => "VIEWER",
                UserEventPayloadVariant255RemovedUsersRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255RemovedUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant255RemovedUsersRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant255RemovedUsersRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant255RemovedUsersRole.Developer,
                "MEMBER" => UserEventPayloadVariant255RemovedUsersRole.Member,
                "OWNER" => UserEventPayloadVariant255RemovedUsersRole.Owner,
                "SECURITY" => UserEventPayloadVariant255RemovedUsersRole.Security,
                "VIEWER" => UserEventPayloadVariant255RemovedUsersRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant255RemovedUsersRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}
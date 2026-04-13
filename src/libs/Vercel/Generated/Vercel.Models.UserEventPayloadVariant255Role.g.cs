
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Role
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
    public static class UserEventPayloadVariant255RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Role value)
        {
            return value switch
            {
                UserEventPayloadVariant255Role.Billing => "BILLING",
                UserEventPayloadVariant255Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant255Role.Developer => "DEVELOPER",
                UserEventPayloadVariant255Role.Member => "MEMBER",
                UserEventPayloadVariant255Role.Owner => "OWNER",
                UserEventPayloadVariant255Role.Security => "SECURITY",
                UserEventPayloadVariant255Role.Viewer => "VIEWER",
                UserEventPayloadVariant255Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant255Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant255Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant255Role.Developer,
                "MEMBER" => UserEventPayloadVariant255Role.Member,
                "OWNER" => UserEventPayloadVariant255Role.Owner,
                "SECURITY" => UserEventPayloadVariant255Role.Security,
                "VIEWER" => UserEventPayloadVariant255Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant255Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
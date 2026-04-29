
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272Role
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
    public static class UserEventPayloadVariant272RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272Role value)
        {
            return value switch
            {
                UserEventPayloadVariant272Role.Billing => "BILLING",
                UserEventPayloadVariant272Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant272Role.Developer => "DEVELOPER",
                UserEventPayloadVariant272Role.Member => "MEMBER",
                UserEventPayloadVariant272Role.Owner => "OWNER",
                UserEventPayloadVariant272Role.Security => "SECURITY",
                UserEventPayloadVariant272Role.Viewer => "VIEWER",
                UserEventPayloadVariant272Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant272Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant272Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant272Role.Developer,
                "MEMBER" => UserEventPayloadVariant272Role.Member,
                "OWNER" => UserEventPayloadVariant272Role.Owner,
                "SECURITY" => UserEventPayloadVariant272Role.Security,
                "VIEWER" => UserEventPayloadVariant272Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant272Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
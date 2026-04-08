
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251Role
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
    public static class UserEventPayloadVariant251RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251Role value)
        {
            return value switch
            {
                UserEventPayloadVariant251Role.Billing => "BILLING",
                UserEventPayloadVariant251Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant251Role.Developer => "DEVELOPER",
                UserEventPayloadVariant251Role.Member => "MEMBER",
                UserEventPayloadVariant251Role.Owner => "OWNER",
                UserEventPayloadVariant251Role.Security => "SECURITY",
                UserEventPayloadVariant251Role.Viewer => "VIEWER",
                UserEventPayloadVariant251Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant251Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant251Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant251Role.Developer,
                "MEMBER" => UserEventPayloadVariant251Role.Member,
                "OWNER" => UserEventPayloadVariant251Role.Owner,
                "SECURITY" => UserEventPayloadVariant251Role.Security,
                "VIEWER" => UserEventPayloadVariant251Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant251Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
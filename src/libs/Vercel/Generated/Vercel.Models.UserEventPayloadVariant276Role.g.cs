
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276Role
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
    public static class UserEventPayloadVariant276RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276Role value)
        {
            return value switch
            {
                UserEventPayloadVariant276Role.Billing => "BILLING",
                UserEventPayloadVariant276Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant276Role.Developer => "DEVELOPER",
                UserEventPayloadVariant276Role.Member => "MEMBER",
                UserEventPayloadVariant276Role.Owner => "OWNER",
                UserEventPayloadVariant276Role.Security => "SECURITY",
                UserEventPayloadVariant276Role.Viewer => "VIEWER",
                UserEventPayloadVariant276Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant276Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant276Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant276Role.Developer,
                "MEMBER" => UserEventPayloadVariant276Role.Member,
                "OWNER" => UserEventPayloadVariant276Role.Owner,
                "SECURITY" => UserEventPayloadVariant276Role.Security,
                "VIEWER" => UserEventPayloadVariant276Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant276Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
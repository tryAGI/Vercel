
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Role
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
    public static class UserEventPayloadVariant250RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Role value)
        {
            return value switch
            {
                UserEventPayloadVariant250Role.Billing => "BILLING",
                UserEventPayloadVariant250Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant250Role.Developer => "DEVELOPER",
                UserEventPayloadVariant250Role.Member => "MEMBER",
                UserEventPayloadVariant250Role.Owner => "OWNER",
                UserEventPayloadVariant250Role.Security => "SECURITY",
                UserEventPayloadVariant250Role.Viewer => "VIEWER",
                UserEventPayloadVariant250Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant250Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant250Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant250Role.Developer,
                "MEMBER" => UserEventPayloadVariant250Role.Member,
                "OWNER" => UserEventPayloadVariant250Role.Owner,
                "SECURITY" => UserEventPayloadVariant250Role.Security,
                "VIEWER" => UserEventPayloadVariant250Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant250Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
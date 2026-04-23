
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265Role
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
    public static class UserEventPayloadVariant265RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265Role value)
        {
            return value switch
            {
                UserEventPayloadVariant265Role.Billing => "BILLING",
                UserEventPayloadVariant265Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant265Role.Developer => "DEVELOPER",
                UserEventPayloadVariant265Role.Member => "MEMBER",
                UserEventPayloadVariant265Role.Owner => "OWNER",
                UserEventPayloadVariant265Role.Security => "SECURITY",
                UserEventPayloadVariant265Role.Viewer => "VIEWER",
                UserEventPayloadVariant265Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant265Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant265Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant265Role.Developer,
                "MEMBER" => UserEventPayloadVariant265Role.Member,
                "OWNER" => UserEventPayloadVariant265Role.Owner,
                "SECURITY" => UserEventPayloadVariant265Role.Security,
                "VIEWER" => UserEventPayloadVariant265Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant265Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
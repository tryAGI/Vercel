
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant261Role
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
    public static class UserEventPayloadVariant261RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261Role value)
        {
            return value switch
            {
                UserEventPayloadVariant261Role.Billing => "BILLING",
                UserEventPayloadVariant261Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant261Role.Developer => "DEVELOPER",
                UserEventPayloadVariant261Role.Member => "MEMBER",
                UserEventPayloadVariant261Role.Owner => "OWNER",
                UserEventPayloadVariant261Role.Security => "SECURITY",
                UserEventPayloadVariant261Role.Viewer => "VIEWER",
                UserEventPayloadVariant261Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant261Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant261Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant261Role.Developer,
                "MEMBER" => UserEventPayloadVariant261Role.Member,
                "OWNER" => UserEventPayloadVariant261Role.Owner,
                "SECURITY" => UserEventPayloadVariant261Role.Security,
                "VIEWER" => UserEventPayloadVariant261Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant261Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
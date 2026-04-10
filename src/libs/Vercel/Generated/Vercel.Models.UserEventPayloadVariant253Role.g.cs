
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant253Role
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
    public static class UserEventPayloadVariant253RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253Role value)
        {
            return value switch
            {
                UserEventPayloadVariant253Role.Billing => "BILLING",
                UserEventPayloadVariant253Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant253Role.Developer => "DEVELOPER",
                UserEventPayloadVariant253Role.Member => "MEMBER",
                UserEventPayloadVariant253Role.Owner => "OWNER",
                UserEventPayloadVariant253Role.Security => "SECURITY",
                UserEventPayloadVariant253Role.Viewer => "VIEWER",
                UserEventPayloadVariant253Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant253Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant253Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant253Role.Developer,
                "MEMBER" => UserEventPayloadVariant253Role.Member,
                "OWNER" => UserEventPayloadVariant253Role.Owner,
                "SECURITY" => UserEventPayloadVariant253Role.Security,
                "VIEWER" => UserEventPayloadVariant253Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant253Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant262Role
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
    public static class UserEventPayloadVariant262RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262Role value)
        {
            return value switch
            {
                UserEventPayloadVariant262Role.Billing => "BILLING",
                UserEventPayloadVariant262Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant262Role.Developer => "DEVELOPER",
                UserEventPayloadVariant262Role.Member => "MEMBER",
                UserEventPayloadVariant262Role.Owner => "OWNER",
                UserEventPayloadVariant262Role.Security => "SECURITY",
                UserEventPayloadVariant262Role.Viewer => "VIEWER",
                UserEventPayloadVariant262Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant262Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant262Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant262Role.Developer,
                "MEMBER" => UserEventPayloadVariant262Role.Member,
                "OWNER" => UserEventPayloadVariant262Role.Owner,
                "SECURITY" => UserEventPayloadVariant262Role.Security,
                "VIEWER" => UserEventPayloadVariant262Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant262Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254Role
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
    public static class UserEventPayloadVariant254RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254Role value)
        {
            return value switch
            {
                UserEventPayloadVariant254Role.Billing => "BILLING",
                UserEventPayloadVariant254Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant254Role.Developer => "DEVELOPER",
                UserEventPayloadVariant254Role.Member => "MEMBER",
                UserEventPayloadVariant254Role.Owner => "OWNER",
                UserEventPayloadVariant254Role.Security => "SECURITY",
                UserEventPayloadVariant254Role.Viewer => "VIEWER",
                UserEventPayloadVariant254Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant254Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant254Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant254Role.Developer,
                "MEMBER" => UserEventPayloadVariant254Role.Member,
                "OWNER" => UserEventPayloadVariant254Role.Owner,
                "SECURITY" => UserEventPayloadVariant254Role.Security,
                "VIEWER" => UserEventPayloadVariant254Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant254Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
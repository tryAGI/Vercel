
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Role
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
    public static class UserEventPayloadVariant264RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Role value)
        {
            return value switch
            {
                UserEventPayloadVariant264Role.Billing => "BILLING",
                UserEventPayloadVariant264Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant264Role.Developer => "DEVELOPER",
                UserEventPayloadVariant264Role.Member => "MEMBER",
                UserEventPayloadVariant264Role.Owner => "OWNER",
                UserEventPayloadVariant264Role.Security => "SECURITY",
                UserEventPayloadVariant264Role.Viewer => "VIEWER",
                UserEventPayloadVariant264Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant264Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant264Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant264Role.Developer,
                "MEMBER" => UserEventPayloadVariant264Role.Member,
                "OWNER" => UserEventPayloadVariant264Role.Owner,
                "SECURITY" => UserEventPayloadVariant264Role.Security,
                "VIEWER" => UserEventPayloadVariant264Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant264Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
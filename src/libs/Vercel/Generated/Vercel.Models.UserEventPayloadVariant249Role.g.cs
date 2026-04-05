
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249Role
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
    public static class UserEventPayloadVariant249RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249Role value)
        {
            return value switch
            {
                UserEventPayloadVariant249Role.Billing => "BILLING",
                UserEventPayloadVariant249Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant249Role.Developer => "DEVELOPER",
                UserEventPayloadVariant249Role.Member => "MEMBER",
                UserEventPayloadVariant249Role.Owner => "OWNER",
                UserEventPayloadVariant249Role.Security => "SECURITY",
                UserEventPayloadVariant249Role.Viewer => "VIEWER",
                UserEventPayloadVariant249Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant249Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant249Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant249Role.Developer,
                "MEMBER" => UserEventPayloadVariant249Role.Member,
                "OWNER" => UserEventPayloadVariant249Role.Owner,
                "SECURITY" => UserEventPayloadVariant249Role.Security,
                "VIEWER" => UserEventPayloadVariant249Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant249Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
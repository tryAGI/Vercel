
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252Role
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
    public static class UserEventPayloadVariant252RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252Role value)
        {
            return value switch
            {
                UserEventPayloadVariant252Role.Billing => "BILLING",
                UserEventPayloadVariant252Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant252Role.Developer => "DEVELOPER",
                UserEventPayloadVariant252Role.Member => "MEMBER",
                UserEventPayloadVariant252Role.Owner => "OWNER",
                UserEventPayloadVariant252Role.Security => "SECURITY",
                UserEventPayloadVariant252Role.Viewer => "VIEWER",
                UserEventPayloadVariant252Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant252Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant252Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant252Role.Developer,
                "MEMBER" => UserEventPayloadVariant252Role.Member,
                "OWNER" => UserEventPayloadVariant252Role.Owner,
                "SECURITY" => UserEventPayloadVariant252Role.Security,
                "VIEWER" => UserEventPayloadVariant252Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant252Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
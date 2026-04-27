
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266Role
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
    public static class UserEventPayloadVariant266RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266Role value)
        {
            return value switch
            {
                UserEventPayloadVariant266Role.Billing => "BILLING",
                UserEventPayloadVariant266Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant266Role.Developer => "DEVELOPER",
                UserEventPayloadVariant266Role.Member => "MEMBER",
                UserEventPayloadVariant266Role.Owner => "OWNER",
                UserEventPayloadVariant266Role.Security => "SECURITY",
                UserEventPayloadVariant266Role.Viewer => "VIEWER",
                UserEventPayloadVariant266Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant266Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant266Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant266Role.Developer,
                "MEMBER" => UserEventPayloadVariant266Role.Member,
                "OWNER" => UserEventPayloadVariant266Role.Owner,
                "SECURITY" => UserEventPayloadVariant266Role.Security,
                "VIEWER" => UserEventPayloadVariant266Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant266Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
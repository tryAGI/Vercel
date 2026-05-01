
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant275Role
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
    public static class UserEventPayloadVariant275RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant275Role value)
        {
            return value switch
            {
                UserEventPayloadVariant275Role.Billing => "BILLING",
                UserEventPayloadVariant275Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant275Role.Developer => "DEVELOPER",
                UserEventPayloadVariant275Role.Member => "MEMBER",
                UserEventPayloadVariant275Role.Owner => "OWNER",
                UserEventPayloadVariant275Role.Security => "SECURITY",
                UserEventPayloadVariant275Role.Viewer => "VIEWER",
                UserEventPayloadVariant275Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant275Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant275Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant275Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant275Role.Developer,
                "MEMBER" => UserEventPayloadVariant275Role.Member,
                "OWNER" => UserEventPayloadVariant275Role.Owner,
                "SECURITY" => UserEventPayloadVariant275Role.Security,
                "VIEWER" => UserEventPayloadVariant275Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant275Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
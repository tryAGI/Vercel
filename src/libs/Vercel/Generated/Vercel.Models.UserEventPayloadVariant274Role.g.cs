
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274Role
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
    public static class UserEventPayloadVariant274RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274Role value)
        {
            return value switch
            {
                UserEventPayloadVariant274Role.Billing => "BILLING",
                UserEventPayloadVariant274Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant274Role.Developer => "DEVELOPER",
                UserEventPayloadVariant274Role.Member => "MEMBER",
                UserEventPayloadVariant274Role.Owner => "OWNER",
                UserEventPayloadVariant274Role.Security => "SECURITY",
                UserEventPayloadVariant274Role.Viewer => "VIEWER",
                UserEventPayloadVariant274Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant274Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant274Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant274Role.Developer,
                "MEMBER" => UserEventPayloadVariant274Role.Member,
                "OWNER" => UserEventPayloadVariant274Role.Owner,
                "SECURITY" => UserEventPayloadVariant274Role.Security,
                "VIEWER" => UserEventPayloadVariant274Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant274Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
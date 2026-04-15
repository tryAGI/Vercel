
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256Role
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
    public static class UserEventPayloadVariant256RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256Role value)
        {
            return value switch
            {
                UserEventPayloadVariant256Role.Billing => "BILLING",
                UserEventPayloadVariant256Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant256Role.Developer => "DEVELOPER",
                UserEventPayloadVariant256Role.Member => "MEMBER",
                UserEventPayloadVariant256Role.Owner => "OWNER",
                UserEventPayloadVariant256Role.Security => "SECURITY",
                UserEventPayloadVariant256Role.Viewer => "VIEWER",
                UserEventPayloadVariant256Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant256Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant256Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant256Role.Developer,
                "MEMBER" => UserEventPayloadVariant256Role.Member,
                "OWNER" => UserEventPayloadVariant256Role.Owner,
                "SECURITY" => UserEventPayloadVariant256Role.Security,
                "VIEWER" => UserEventPayloadVariant256Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant256Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}
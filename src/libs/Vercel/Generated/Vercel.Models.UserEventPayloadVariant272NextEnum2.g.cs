
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272NextEnum2
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
    public static class UserEventPayloadVariant272NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant272NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant272NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant272NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant272NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant272NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant272NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant272NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant272NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant272NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant272NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant272NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant272NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant272NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant272NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant272NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant272NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
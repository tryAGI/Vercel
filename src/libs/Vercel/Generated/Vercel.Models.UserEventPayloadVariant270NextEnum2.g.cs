
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270NextEnum2
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
    public static class UserEventPayloadVariant270NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant270NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant270NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant270NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant270NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant270NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant270NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant270NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant270NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant270NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant270NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant270NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant270NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant270NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant270NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant270NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant270NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
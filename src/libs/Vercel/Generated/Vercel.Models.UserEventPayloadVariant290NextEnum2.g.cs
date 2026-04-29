
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290NextEnum2
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
    public static class UserEventPayloadVariant290NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant290NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant290NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant290NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant290NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant290NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant290NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant290NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant290NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant290NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant290NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant290NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant290NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant290NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant290NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant290NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant290NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
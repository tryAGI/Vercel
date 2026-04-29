
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant292NextEnum2
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
    public static class UserEventPayloadVariant292NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant292NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant292NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant292NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant292NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant292NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant292NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant292NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant292NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant292NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant292NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant292NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant292NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant292NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant292NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant292NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant292NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant292NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant292NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
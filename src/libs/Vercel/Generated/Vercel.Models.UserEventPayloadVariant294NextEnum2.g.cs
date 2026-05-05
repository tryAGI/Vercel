
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant294NextEnum2
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
    public static class UserEventPayloadVariant294NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant294NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant294NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant294NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant294NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant294NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant294NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant294NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant294NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant294NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant294NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant294NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant294NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant294NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant294NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant294NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant294NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant294NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant294NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267NextEnum2
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
    public static class UserEventPayloadVariant267NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant267NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant267NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant267NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant267NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant267NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant267NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant267NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant267NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant267NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant267NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant267NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant267NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant267NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant267NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant267NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant267NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant282NextEnum2
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
    public static class UserEventPayloadVariant282NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant282NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant282NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant282NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant282NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant282NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant282NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant282NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant282NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant282NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant282NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant282NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant282NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant282NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant282NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant282NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant282NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant282NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant282NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
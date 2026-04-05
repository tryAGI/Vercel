
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265NextEnum2
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
    public static class UserEventPayloadVariant265NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant265NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant265NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant265NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant265NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant265NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant265NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant265NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant265NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant265NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant265NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant265NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant265NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant265NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant265NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant265NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant265NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
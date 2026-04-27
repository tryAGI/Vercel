
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant284NextEnum2
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
    public static class UserEventPayloadVariant284NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant284NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant284NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant284NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant284NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant284NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant284NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant284NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant284NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant284NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant284NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant284NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant284NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant284NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant284NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant284NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant284NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant284NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant284NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
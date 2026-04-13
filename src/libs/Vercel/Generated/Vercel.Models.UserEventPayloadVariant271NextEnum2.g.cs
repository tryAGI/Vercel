
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant271NextEnum2
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
    public static class UserEventPayloadVariant271NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant271NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant271NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant271NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant271NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant271NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant271NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant271NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant271NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant271NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant271NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant271NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant271NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant271NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant271NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant271NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant271NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant271NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant271NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
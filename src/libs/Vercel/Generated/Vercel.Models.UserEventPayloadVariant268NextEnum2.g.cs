
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant268NextEnum2
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
    public static class UserEventPayloadVariant268NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant268NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant268NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant268NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant268NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant268NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant268NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant268NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant268NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant268NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant268NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant268NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant268NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant268NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant268NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant268NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant268NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant268NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant268NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
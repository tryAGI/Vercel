
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272PreviousEnum2
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
    public static class UserEventPayloadVariant272PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant272PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant272PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant272PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant272PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant272PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant272PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant272PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant272PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant272PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant272PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant272PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant272PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant272PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant272PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant272PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant272PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
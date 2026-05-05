
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant294PreviousEnum2
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
    public static class UserEventPayloadVariant294PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant294PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant294PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant294PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant294PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant294PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant294PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant294PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant294PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant294PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant294PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant294PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant294PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant294PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant294PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant294PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant294PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant294PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant294PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
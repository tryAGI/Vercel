
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265PreviousEnum2
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
    public static class UserEventPayloadVariant265PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant265PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant265PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant265PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant265PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant265PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant265PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant265PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant265PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant265PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant265PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant265PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant265PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant265PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant265PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant265PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant265PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
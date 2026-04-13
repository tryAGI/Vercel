
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270PreviousEnum2
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
    public static class UserEventPayloadVariant270PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant270PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant270PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant270PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant270PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant270PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant270PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant270PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant270PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant270PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant270PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant270PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant270PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant270PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant270PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant270PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant270PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
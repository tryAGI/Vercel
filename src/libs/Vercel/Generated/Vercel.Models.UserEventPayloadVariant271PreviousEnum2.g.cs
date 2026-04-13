
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant271PreviousEnum2
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
    public static class UserEventPayloadVariant271PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant271PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant271PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant271PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant271PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant271PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant271PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant271PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant271PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant271PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant271PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant271PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant271PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant271PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant271PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant271PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant271PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant271PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant271PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
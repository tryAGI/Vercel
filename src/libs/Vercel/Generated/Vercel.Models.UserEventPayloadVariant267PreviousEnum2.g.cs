
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267PreviousEnum2
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
    public static class UserEventPayloadVariant267PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant267PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant267PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant267PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant267PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant267PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant267PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant267PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant267PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant267PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant267PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant267PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant267PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant267PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant267PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant267PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant267PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
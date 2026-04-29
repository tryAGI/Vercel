
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant292PreviousEnum2
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
    public static class UserEventPayloadVariant292PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant292PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant292PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant292PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant292PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant292PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant292PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant292PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant292PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant292PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant292PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant292PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant292PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant292PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant292PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant292PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant292PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant292PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant292PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
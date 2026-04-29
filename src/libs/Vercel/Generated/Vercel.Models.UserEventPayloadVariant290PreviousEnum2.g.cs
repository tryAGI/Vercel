
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290PreviousEnum2
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
    public static class UserEventPayloadVariant290PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant290PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant290PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant290PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant290PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant290PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant290PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant290PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant290PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant290PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant290PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant290PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant290PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant290PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant290PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant290PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant290PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
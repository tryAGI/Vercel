
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant283PreviousEnum2
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
    public static class UserEventPayloadVariant283PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant283PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant283PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant283PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant283PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant283PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant283PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant283PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant283PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant283PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant283PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant283PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant283PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant283PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant283PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant283PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant283PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant283PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant283PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
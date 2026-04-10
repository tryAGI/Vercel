
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant268PreviousEnum2
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
    public static class UserEventPayloadVariant268PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant268PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant268PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant268PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant268PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant268PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant268PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant268PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant268PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant268PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant268PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant268PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant268PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant268PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant268PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant268PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant268PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant268PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant268PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
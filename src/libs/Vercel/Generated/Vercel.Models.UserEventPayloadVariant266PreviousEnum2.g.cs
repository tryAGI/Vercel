
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266PreviousEnum2
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
    public static class UserEventPayloadVariant266PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant266PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant266PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant266PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant266PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant266PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant266PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant266PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant266PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant266PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant266PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant266PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant266PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant266PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant266PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant266PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant266PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
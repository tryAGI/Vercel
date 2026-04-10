
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant269PreviousEnum2
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
    public static class UserEventPayloadVariant269PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant269PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant269PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant269PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant269PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant269PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant269PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant269PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant269PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant269PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant269PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant269PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant269PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant269PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant269PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant269PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant269PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant269PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant269PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
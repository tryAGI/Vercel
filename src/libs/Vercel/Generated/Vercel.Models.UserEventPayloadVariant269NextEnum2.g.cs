
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant269NextEnum2
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
    public static class UserEventPayloadVariant269NextEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant269NextEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant269NextEnum2.Billing => "BILLING",
                UserEventPayloadVariant269NextEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant269NextEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant269NextEnum2.Member => "MEMBER",
                UserEventPayloadVariant269NextEnum2.Owner => "OWNER",
                UserEventPayloadVariant269NextEnum2.Security => "SECURITY",
                UserEventPayloadVariant269NextEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant269NextEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant269NextEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant269NextEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant269NextEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant269NextEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant269NextEnum2.Member,
                "OWNER" => UserEventPayloadVariant269NextEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant269NextEnum2.Security,
                "VIEWER" => UserEventPayloadVariant269NextEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant269NextEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant293PreviousEnum2
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
    public static class UserEventPayloadVariant293PreviousEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant293PreviousEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant293PreviousEnum2.Billing => "BILLING",
                UserEventPayloadVariant293PreviousEnum2.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant293PreviousEnum2.Developer => "DEVELOPER",
                UserEventPayloadVariant293PreviousEnum2.Member => "MEMBER",
                UserEventPayloadVariant293PreviousEnum2.Owner => "OWNER",
                UserEventPayloadVariant293PreviousEnum2.Security => "SECURITY",
                UserEventPayloadVariant293PreviousEnum2.Viewer => "VIEWER",
                UserEventPayloadVariant293PreviousEnum2.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant293PreviousEnum2? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant293PreviousEnum2.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant293PreviousEnum2.Contributor,
                "DEVELOPER" => UserEventPayloadVariant293PreviousEnum2.Developer,
                "MEMBER" => UserEventPayloadVariant293PreviousEnum2.Member,
                "OWNER" => UserEventPayloadVariant293PreviousEnum2.Owner,
                "SECURITY" => UserEventPayloadVariant293PreviousEnum2.Security,
                "VIEWER" => UserEventPayloadVariant293PreviousEnum2.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant293PreviousEnum2.ViewerForPlus,
                _ => null,
            };
        }
    }
}
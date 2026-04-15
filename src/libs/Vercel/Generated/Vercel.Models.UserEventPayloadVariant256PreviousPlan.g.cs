
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256PreviousPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant256PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant256PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant256PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant256PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant256PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant256PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant256PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}
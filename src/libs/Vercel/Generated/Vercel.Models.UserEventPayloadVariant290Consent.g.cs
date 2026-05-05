
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290Consent
    {
        /// <summary>
        /// 
        /// </summary>
        Granted,
        /// <summary>
        /// 
        /// </summary>
        Refused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant290ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant290Consent.Granted => "granted",
                UserEventPayloadVariant290Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant290Consent.Granted,
                "refused" => UserEventPayloadVariant290Consent.Refused,
                _ => null,
            };
        }
    }
}
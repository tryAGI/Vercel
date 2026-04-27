
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant280Consent
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
    public static class UserEventPayloadVariant280ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant280Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant280Consent.Granted => "granted",
                UserEventPayloadVariant280Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant280Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant280Consent.Granted,
                "refused" => UserEventPayloadVariant280Consent.Refused,
                _ => null,
            };
        }
    }
}
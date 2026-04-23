
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276Consent
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
    public static class UserEventPayloadVariant276ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant276Consent.Granted => "granted",
                UserEventPayloadVariant276Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant276Consent.Granted,
                "refused" => UserEventPayloadVariant276Consent.Refused,
                _ => null,
            };
        }
    }
}
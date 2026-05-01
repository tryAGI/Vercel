
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant289Consent
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
    public static class UserEventPayloadVariant289ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant289Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant289Consent.Granted => "granted",
                UserEventPayloadVariant289Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant289Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant289Consent.Granted,
                "refused" => UserEventPayloadVariant289Consent.Refused,
                _ => null,
            };
        }
    }
}
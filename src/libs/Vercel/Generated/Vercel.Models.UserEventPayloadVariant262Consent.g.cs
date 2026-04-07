
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant262Consent
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
    public static class UserEventPayloadVariant262ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant262Consent.Granted => "granted",
                UserEventPayloadVariant262Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant262Consent.Granted,
                "refused" => UserEventPayloadVariant262Consent.Refused,
                _ => null,
            };
        }
    }
}
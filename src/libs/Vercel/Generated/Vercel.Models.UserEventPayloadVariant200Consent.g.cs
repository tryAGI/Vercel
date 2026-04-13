
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant200Consent
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
    public static class UserEventPayloadVariant200ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant200Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant200Consent.Granted => "granted",
                UserEventPayloadVariant200Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant200Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant200Consent.Granted,
                "refused" => UserEventPayloadVariant200Consent.Refused,
                _ => null,
            };
        }
    }
}
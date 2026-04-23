
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant207Consent
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
    public static class UserEventPayloadVariant207ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant207Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant207Consent.Granted => "granted",
                UserEventPayloadVariant207Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant207Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant207Consent.Granted,
                "refused" => UserEventPayloadVariant207Consent.Refused,
                _ => null,
            };
        }
    }
}
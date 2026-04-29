
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant288Consent
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
    public static class UserEventPayloadVariant288ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant288Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant288Consent.Granted => "granted",
                UserEventPayloadVariant288Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant288Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant288Consent.Granted,
                "refused" => UserEventPayloadVariant288Consent.Refused,
                _ => null,
            };
        }
    }
}
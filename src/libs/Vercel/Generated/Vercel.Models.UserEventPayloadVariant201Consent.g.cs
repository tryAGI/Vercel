
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant201Consent
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
    public static class UserEventPayloadVariant201ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant201Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant201Consent.Granted => "granted",
                UserEventPayloadVariant201Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant201Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant201Consent.Granted,
                "refused" => UserEventPayloadVariant201Consent.Refused,
                _ => null,
            };
        }
    }
}
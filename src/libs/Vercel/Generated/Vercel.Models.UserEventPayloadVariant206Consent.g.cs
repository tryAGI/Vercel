
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant206Consent
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
    public static class UserEventPayloadVariant206ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant206Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant206Consent.Granted => "granted",
                UserEventPayloadVariant206Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant206Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant206Consent.Granted,
                "refused" => UserEventPayloadVariant206Consent.Refused,
                _ => null,
            };
        }
    }
}
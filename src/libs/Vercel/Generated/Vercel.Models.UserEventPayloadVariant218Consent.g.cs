
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant218Consent
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
    public static class UserEventPayloadVariant218ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant218Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant218Consent.Granted => "granted",
                UserEventPayloadVariant218Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant218Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant218Consent.Granted,
                "refused" => UserEventPayloadVariant218Consent.Refused,
                _ => null,
            };
        }
    }
}
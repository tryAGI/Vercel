
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant263Consent
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
    public static class UserEventPayloadVariant263ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant263Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant263Consent.Granted => "granted",
                UserEventPayloadVariant263Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant263Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant263Consent.Granted,
                "refused" => UserEventPayloadVariant263Consent.Refused,
                _ => null,
            };
        }
    }
}
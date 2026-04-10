
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant197Consent
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
    public static class UserEventPayloadVariant197ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant197Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant197Consent.Granted => "granted",
                UserEventPayloadVariant197Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant197Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant197Consent.Granted,
                "refused" => UserEventPayloadVariant197Consent.Refused,
                _ => null,
            };
        }
    }
}
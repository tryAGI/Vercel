
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant286Consent
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
    public static class UserEventPayloadVariant286ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant286Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant286Consent.Granted => "granted",
                UserEventPayloadVariant286Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant286Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant286Consent.Granted,
                "refused" => UserEventPayloadVariant286Consent.Refused,
                _ => null,
            };
        }
    }
}
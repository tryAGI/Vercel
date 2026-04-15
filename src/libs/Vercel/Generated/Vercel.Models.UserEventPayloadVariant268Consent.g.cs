
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant268Consent
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
    public static class UserEventPayloadVariant268ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant268Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant268Consent.Granted => "granted",
                UserEventPayloadVariant268Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant268Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant268Consent.Granted,
                "refused" => UserEventPayloadVariant268Consent.Refused,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant199Consent
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
    public static class UserEventPayloadVariant199ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant199Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant199Consent.Granted => "granted",
                UserEventPayloadVariant199Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant199Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant199Consent.Granted,
                "refused" => UserEventPayloadVariant199Consent.Refused,
                _ => null,
            };
        }
    }
}
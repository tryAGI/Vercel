
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265Consent
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
    public static class UserEventPayloadVariant265ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant265Consent.Granted => "granted",
                UserEventPayloadVariant265Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant265Consent.Granted,
                "refused" => UserEventPayloadVariant265Consent.Refused,
                _ => null,
            };
        }
    }
}
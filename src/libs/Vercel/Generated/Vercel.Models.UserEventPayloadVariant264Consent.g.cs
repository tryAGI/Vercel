
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Consent
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
    public static class UserEventPayloadVariant264ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant264Consent.Granted => "granted",
                UserEventPayloadVariant264Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant264Consent.Granted,
                "refused" => UserEventPayloadVariant264Consent.Refused,
                _ => null,
            };
        }
    }
}
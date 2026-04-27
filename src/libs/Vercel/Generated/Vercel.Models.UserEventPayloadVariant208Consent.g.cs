
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant208Consent
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
    public static class UserEventPayloadVariant208ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant208Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant208Consent.Granted => "granted",
                UserEventPayloadVariant208Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant208Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant208Consent.Granted,
                "refused" => UserEventPayloadVariant208Consent.Refused,
                _ => null,
            };
        }
    }
}
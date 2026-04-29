
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant216Consent
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
    public static class UserEventPayloadVariant216ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant216Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant216Consent.Granted => "granted",
                UserEventPayloadVariant216Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant216Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant216Consent.Granted,
                "refused" => UserEventPayloadVariant216Consent.Refused,
                _ => null,
            };
        }
    }
}
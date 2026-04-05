
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant261Consent
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
    public static class UserEventPayloadVariant261ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant261Consent.Granted => "granted",
                UserEventPayloadVariant261Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant261Consent.Granted,
                "refused" => UserEventPayloadVariant261Consent.Refused,
                _ => null,
            };
        }
    }
}
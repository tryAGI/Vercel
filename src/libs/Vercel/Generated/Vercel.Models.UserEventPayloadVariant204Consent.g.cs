
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant204Consent
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
    public static class UserEventPayloadVariant204ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant204Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant204Consent.Granted => "granted",
                UserEventPayloadVariant204Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant204Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant204Consent.Granted,
                "refused" => UserEventPayloadVariant204Consent.Refused,
                _ => null,
            };
        }
    }
}
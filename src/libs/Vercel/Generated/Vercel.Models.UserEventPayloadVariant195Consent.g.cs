
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant195Consent
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
    public static class UserEventPayloadVariant195ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant195Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant195Consent.Granted => "granted",
                UserEventPayloadVariant195Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant195Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant195Consent.Granted,
                "refused" => UserEventPayloadVariant195Consent.Refused,
                _ => null,
            };
        }
    }
}
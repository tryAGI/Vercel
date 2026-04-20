
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant273Consent
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
    public static class UserEventPayloadVariant273ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant273Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant273Consent.Granted => "granted",
                UserEventPayloadVariant273Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant273Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant273Consent.Granted,
                "refused" => UserEventPayloadVariant273Consent.Refused,
                _ => null,
            };
        }
    }
}
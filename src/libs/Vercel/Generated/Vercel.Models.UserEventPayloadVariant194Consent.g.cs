
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant194Consent
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
    public static class UserEventPayloadVariant194ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant194Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant194Consent.Granted => "granted",
                UserEventPayloadVariant194Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant194Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant194Consent.Granted,
                "refused" => UserEventPayloadVariant194Consent.Refused,
                _ => null,
            };
        }
    }
}
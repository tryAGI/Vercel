
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272Consent
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
    public static class UserEventPayloadVariant272ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant272Consent.Granted => "granted",
                UserEventPayloadVariant272Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant272Consent.Granted,
                "refused" => UserEventPayloadVariant272Consent.Refused,
                _ => null,
            };
        }
    }
}
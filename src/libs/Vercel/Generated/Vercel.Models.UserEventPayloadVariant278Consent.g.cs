
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant278Consent
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
    public static class UserEventPayloadVariant278ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant278Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant278Consent.Granted => "granted",
                UserEventPayloadVariant278Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant278Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant278Consent.Granted,
                "refused" => UserEventPayloadVariant278Consent.Refused,
                _ => null,
            };
        }
    }
}
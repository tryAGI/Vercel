
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266Consent
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
    public static class UserEventPayloadVariant266ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant266Consent.Granted => "granted",
                UserEventPayloadVariant266Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant266Consent.Granted,
                "refused" => UserEventPayloadVariant266Consent.Refused,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant217Consent
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
    public static class UserEventPayloadVariant217ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant217Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant217Consent.Granted => "granted",
                UserEventPayloadVariant217Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant217Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant217Consent.Granted,
                "refused" => UserEventPayloadVariant217Consent.Refused,
                _ => null,
            };
        }
    }
}
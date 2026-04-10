
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant198Consent
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
    public static class UserEventPayloadVariant198ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant198Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant198Consent.Granted => "granted",
                UserEventPayloadVariant198Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant198Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant198Consent.Granted,
                "refused" => UserEventPayloadVariant198Consent.Refused,
                _ => null,
            };
        }
    }
}
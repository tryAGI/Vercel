
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274Consent
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
    public static class UserEventPayloadVariant274ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant274Consent.Granted => "granted",
                UserEventPayloadVariant274Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant274Consent.Granted,
                "refused" => UserEventPayloadVariant274Consent.Refused,
                _ => null,
            };
        }
    }
}
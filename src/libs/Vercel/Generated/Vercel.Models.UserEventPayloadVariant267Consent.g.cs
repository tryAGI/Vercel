
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267Consent
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
    public static class UserEventPayloadVariant267ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant267Consent.Granted => "granted",
                UserEventPayloadVariant267Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant267Consent.Granted,
                "refused" => UserEventPayloadVariant267Consent.Refused,
                _ => null,
            };
        }
    }
}
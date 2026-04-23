
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant279Consent
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
    public static class UserEventPayloadVariant279ConsentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant279Consent value)
        {
            return value switch
            {
                UserEventPayloadVariant279Consent.Granted => "granted",
                UserEventPayloadVariant279Consent.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant279Consent? ToEnum(string value)
        {
            return value switch
            {
                "granted" => UserEventPayloadVariant279Consent.Granted,
                "refused" => UserEventPayloadVariant279Consent.Refused,
                _ => null,
            };
        }
    }
}
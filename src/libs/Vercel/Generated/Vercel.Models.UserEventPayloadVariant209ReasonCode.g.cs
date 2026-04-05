
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant209ReasonCode
    {
        /// <summary>
        /// 
        /// </summary>
        Backoffice,
        /// <summary>
        /// 
        /// </summary>
        PublicApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant209ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant209ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant209ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant209ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant209ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant209ReasonCode.Backoffice,
                "PUBLIC_API" => UserEventPayloadVariant209ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}
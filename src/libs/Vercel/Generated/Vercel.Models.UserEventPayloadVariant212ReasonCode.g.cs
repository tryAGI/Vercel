
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant212ReasonCode
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
    public static class UserEventPayloadVariant212ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant212ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant212ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant212ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant212ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant212ReasonCode.Backoffice,
                "PUBLIC_API" => UserEventPayloadVariant212ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}
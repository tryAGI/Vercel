
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant214ReasonCode
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
    public static class UserEventPayloadVariant214ReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant214ReasonCode value)
        {
            return value switch
            {
                UserEventPayloadVariant214ReasonCode.Backoffice => "BACKOFFICE",
                UserEventPayloadVariant214ReasonCode.PublicApi => "PUBLIC_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant214ReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "BACKOFFICE" => UserEventPayloadVariant214ReasonCode.Backoffice,
                "PUBLIC_API" => UserEventPayloadVariant214ReasonCode.PublicApi,
                _ => null,
            };
        }
    }
}
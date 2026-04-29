
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant45DataReason
    {
        /// <summary>
        /// 
        /// </summary>
        NonPayment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant45DataReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant45DataReason value)
        {
            return value switch
            {
                UserEventPayloadVariant45DataReason.NonPayment => "non-payment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant45DataReason? ToEnum(string value)
        {
            return value switch
            {
                "non-payment" => UserEventPayloadVariant45DataReason.NonPayment,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant38DataReason
    {
        /// <summary>
        /// 
        /// </summary>
        NonPayment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant38DataReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant38DataReason value)
        {
            return value switch
            {
                UserEventPayloadVariant38DataReason.NonPayment => "non-payment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant38DataReason? ToEnum(string value)
        {
            return value switch
            {
                "non-payment" => UserEventPayloadVariant38DataReason.NonPayment,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant39DataReason
    {
        /// <summary>
        /// 
        /// </summary>
        NonPayment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant39DataReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant39DataReason value)
        {
            return value switch
            {
                UserEventPayloadVariant39DataReason.NonPayment => "non-payment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant39DataReason? ToEnum(string value)
        {
            return value switch
            {
                "non-payment" => UserEventPayloadVariant39DataReason.NonPayment,
                _ => null,
            };
        }
    }
}
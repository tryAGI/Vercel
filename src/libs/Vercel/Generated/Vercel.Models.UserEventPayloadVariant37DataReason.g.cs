
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant37DataReason
    {
        /// <summary>
        /// 
        /// </summary>
        NonPayment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant37DataReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant37DataReason value)
        {
            return value switch
            {
                UserEventPayloadVariant37DataReason.NonPayment => "non-payment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant37DataReason? ToEnum(string value)
        {
            return value switch
            {
                "non-payment" => UserEventPayloadVariant37DataReason.NonPayment,
                _ => null,
            };
        }
    }
}
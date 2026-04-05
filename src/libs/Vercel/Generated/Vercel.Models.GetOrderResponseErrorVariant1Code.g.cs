
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseErrorVariant1Code
    {
        /// <summary>
        /// 
        /// </summary>
        PaymentFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant1CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant1Code value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant1Code.PaymentFailed => "payment-failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant1Code? ToEnum(string value)
        {
            return value switch
            {
                "payment-failed" => GetOrderResponseErrorVariant1Code.PaymentFailed,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseErrorVariant3Code
    {
        /// <summary>
        /// 
        /// </summary>
        PriceMismatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant3CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant3Code value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant3Code.PriceMismatch => "price-mismatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant3Code? ToEnum(string value)
        {
            return value switch
            {
                "price-mismatch" => GetOrderResponseErrorVariant3Code.PriceMismatch,
                _ => null,
            };
        }
    }
}
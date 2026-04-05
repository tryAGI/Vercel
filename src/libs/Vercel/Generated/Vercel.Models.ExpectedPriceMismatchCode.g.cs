
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpectedPriceMismatchCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExpectedPriceMismatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpectedPriceMismatchCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpectedPriceMismatchCode value)
        {
            return value switch
            {
                ExpectedPriceMismatchCode.ExpectedPriceMismatch => "expected_price_mismatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpectedPriceMismatchCode? ToEnum(string value)
        {
            return value switch
            {
                "expected_price_mismatch" => ExpectedPriceMismatchCode.ExpectedPriceMismatch,
                _ => null,
            };
        }
    }
}
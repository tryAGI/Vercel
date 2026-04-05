
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant8Code
    {
        /// <summary>
        /// 
        /// </summary>
        PriceChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant8CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant8Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant8Code.PriceChange => "price-change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant8Code? ToEnum(string value)
        {
            return value switch
            {
                "price-change" => GetOrderResponseDomainVariant3ErrorVariant8Code.PriceChange,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant1PurchaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Purchase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant1PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant1PurchaseType value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant1PurchaseType.Purchase => "purchase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant1PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "purchase" => GetOrderResponseDomainVariant1PurchaseType.Purchase,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3PurchaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Transfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3PurchaseType value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3PurchaseType.Transfer => "transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "transfer" => GetOrderResponseDomainVariant3PurchaseType.Transfer,
                _ => null,
            };
        }
    }
}
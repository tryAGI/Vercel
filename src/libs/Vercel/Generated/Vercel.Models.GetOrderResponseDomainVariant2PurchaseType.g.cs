
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant2PurchaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Renewal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant2PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant2PurchaseType value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant2PurchaseType.Renewal => "renewal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant2PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "renewal" => GetOrderResponseDomainVariant2PurchaseType.Renewal,
                _ => null,
            };
        }
    }
}
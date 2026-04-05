
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant7Code
    {
        /// <summary>
        /// 
        /// </summary>
        AccountTransferRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant7CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant7Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant7Code.AccountTransferRequired => "account-transfer-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant7Code? ToEnum(string value)
        {
            return value switch
            {
                "account-transfer-required" => GetOrderResponseDomainVariant3ErrorVariant7Code.AccountTransferRequired,
                _ => null,
            };
        }
    }
}
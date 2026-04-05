
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant2ErrorVariant3Code
    {
        /// <summary>
        /// 
        /// </summary>
        ClientTransferProhibited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant2ErrorVariant3CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant2ErrorVariant3Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant2ErrorVariant3Code.ClientTransferProhibited => "client-transfer-prohibited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant2ErrorVariant3Code? ToEnum(string value)
        {
            return value switch
            {
                "client-transfer-prohibited" => GetOrderResponseDomainVariant2ErrorVariant3Code.ClientTransferProhibited,
                _ => null,
            };
        }
    }
}
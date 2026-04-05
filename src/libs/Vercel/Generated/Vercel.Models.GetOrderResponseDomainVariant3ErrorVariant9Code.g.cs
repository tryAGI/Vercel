
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant9Code
    {
        /// <summary>
        /// 
        /// </summary>
        UnavailableLegal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant9CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant9Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant9Code.UnavailableLegal => "unavailable-legal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant9Code? ToEnum(string value)
        {
            return value switch
            {
                "unavailable-legal" => GetOrderResponseDomainVariant3ErrorVariant9Code.UnavailableLegal,
                _ => null,
            };
        }
    }
}
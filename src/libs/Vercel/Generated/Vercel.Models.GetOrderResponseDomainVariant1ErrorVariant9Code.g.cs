
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant1ErrorVariant9Code
    {
        /// <summary>
        /// 
        /// </summary>
        UnavailableLegal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant1ErrorVariant9CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant1ErrorVariant9Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant1ErrorVariant9Code.UnavailableLegal => "unavailable-legal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant1ErrorVariant9Code? ToEnum(string value)
        {
            return value switch
            {
                "unavailable-legal" => GetOrderResponseDomainVariant1ErrorVariant9Code.UnavailableLegal,
                _ => null,
            };
        }
    }
}
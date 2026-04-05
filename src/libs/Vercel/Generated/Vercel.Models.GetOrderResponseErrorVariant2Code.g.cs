
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseErrorVariant2Code
    {
        /// <summary>
        /// 
        /// </summary>
        TldOutage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant2CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant2Code value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant2Code.TldOutage => "tld-outage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant2Code? ToEnum(string value)
        {
            return value switch
            {
                "tld-outage" => GetOrderResponseErrorVariant2Code.TldOutage,
                _ => null,
            };
        }
    }
}
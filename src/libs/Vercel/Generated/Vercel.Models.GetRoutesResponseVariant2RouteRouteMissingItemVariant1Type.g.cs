
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant2RouteRouteMissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}
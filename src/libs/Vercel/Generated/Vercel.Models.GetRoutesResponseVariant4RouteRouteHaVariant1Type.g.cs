
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteHaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant4RouteRouteHaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteHaVariant1Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteHaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteHaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => GetRoutesResponseVariant4RouteRouteHaVariant1Type.Host,
                _ => null,
            };
        }
    }
}
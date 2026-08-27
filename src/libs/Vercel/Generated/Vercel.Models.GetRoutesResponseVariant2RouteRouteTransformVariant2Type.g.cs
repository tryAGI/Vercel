
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteTransformVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant2RouteRouteTransformVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteTransformVariant2Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteTransformVariant2Type.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteTransformVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => GetRoutesResponseVariant2RouteRouteTransformVariant2Type.RequestPath,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteTransformVariant1Op
    {
        /// <summary>
        ///
        /// </summary>
        Append,
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant2RouteRouteTransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteTransformVariant1Op value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteTransformVariant1Op.Append => "append",
                GetRoutesResponseVariant2RouteRouteTransformVariant1Op.Delete => "delete",
                GetRoutesResponseVariant2RouteRouteTransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteTransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetRoutesResponseVariant2RouteRouteTransformVariant1Op.Append,
                "delete" => GetRoutesResponseVariant2RouteRouteTransformVariant1Op.Delete,
                "set" => GetRoutesResponseVariant2RouteRouteTransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}
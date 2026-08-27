
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutesResponseVariant3RouteRouteTransformVariant1Op
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
    public static class GetRoutesResponseVariant3RouteRouteTransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteRouteTransformVariant1Op value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteRouteTransformVariant1Op.Append => "append",
                GetRoutesResponseVariant3RouteRouteTransformVariant1Op.Delete => "delete",
                GetRoutesResponseVariant3RouteRouteTransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteRouteTransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetRoutesResponseVariant3RouteRouteTransformVariant1Op.Append,
                "delete" => GetRoutesResponseVariant3RouteRouteTransformVariant1Op.Delete,
                "set" => GetRoutesResponseVariant3RouteRouteTransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}
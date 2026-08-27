
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteTransformVariant1Op
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
    public static class GetRoutesResponseVariant4RouteRouteTransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteTransformVariant1Op value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteTransformVariant1Op.Append => "append",
                GetRoutesResponseVariant4RouteRouteTransformVariant1Op.Delete => "delete",
                GetRoutesResponseVariant4RouteRouteTransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteTransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetRoutesResponseVariant4RouteRouteTransformVariant1Op.Append,
                "delete" => GetRoutesResponseVariant4RouteRouteTransformVariant1Op.Delete,
                "set" => GetRoutesResponseVariant4RouteRouteTransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}
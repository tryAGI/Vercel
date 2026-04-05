
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteTransformOp
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
    public static class GetRoutesResponseVariant4RouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteTransformOp value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteTransformOp.Append => "append",
                GetRoutesResponseVariant4RouteRouteTransformOp.Delete => "delete",
                GetRoutesResponseVariant4RouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetRoutesResponseVariant4RouteRouteTransformOp.Append,
                "delete" => GetRoutesResponseVariant4RouteRouteTransformOp.Delete,
                "set" => GetRoutesResponseVariant4RouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant3RouteRouteTransformOp
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
    public static class GetRoutesResponseVariant3RouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteRouteTransformOp value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteRouteTransformOp.Append => "append",
                GetRoutesResponseVariant3RouteRouteTransformOp.Delete => "delete",
                GetRoutesResponseVariant3RouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetRoutesResponseVariant3RouteRouteTransformOp.Append,
                "delete" => GetRoutesResponseVariant3RouteRouteTransformOp.Delete,
                "set" => GetRoutesResponseVariant3RouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteTransformOp
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
    public static class GetRoutesResponseVariant2RouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteTransformOp value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteTransformOp.Append => "append",
                GetRoutesResponseVariant2RouteRouteTransformOp.Delete => "delete",
                GetRoutesResponseVariant2RouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetRoutesResponseVariant2RouteRouteTransformOp.Append,
                "delete" => GetRoutesResponseVariant2RouteRouteTransformOp.Delete,
                "set" => GetRoutesResponseVariant2RouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}
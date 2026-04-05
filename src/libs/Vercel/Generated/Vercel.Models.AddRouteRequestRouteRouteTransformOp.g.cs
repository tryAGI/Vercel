
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteRequestRouteRouteTransformOp
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
    public static class AddRouteRequestRouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteRequestRouteRouteTransformOp value)
        {
            return value switch
            {
                AddRouteRequestRouteRouteTransformOp.Append => "append",
                AddRouteRequestRouteRouteTransformOp.Delete => "delete",
                AddRouteRequestRouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteRequestRouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => AddRouteRequestRouteRouteTransformOp.Append,
                "delete" => AddRouteRequestRouteRouteTransformOp.Delete,
                "set" => AddRouteRequestRouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}
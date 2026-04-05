
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteTransformOp
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
    public static class AddRouteResponseRouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteTransformOp value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteTransformOp.Append => "append",
                AddRouteResponseRouteRouteTransformOp.Delete => "delete",
                AddRouteResponseRouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => AddRouteResponseRouteRouteTransformOp.Append,
                "delete" => AddRouteResponseRouteRouteTransformOp.Delete,
                "set" => AddRouteResponseRouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}
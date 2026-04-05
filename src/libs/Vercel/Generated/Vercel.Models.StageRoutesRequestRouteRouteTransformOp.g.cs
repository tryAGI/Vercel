
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum StageRoutesRequestRouteRouteTransformOp
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
    public static class StageRoutesRequestRouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StageRoutesRequestRouteRouteTransformOp value)
        {
            return value switch
            {
                StageRoutesRequestRouteRouteTransformOp.Append => "append",
                StageRoutesRequestRouteRouteTransformOp.Delete => "delete",
                StageRoutesRequestRouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StageRoutesRequestRouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => StageRoutesRequestRouteRouteTransformOp.Append,
                "delete" => StageRoutesRequestRouteRouteTransformOp.Delete,
                "set" => StageRoutesRequestRouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}
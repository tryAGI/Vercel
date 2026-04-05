
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteTransformOp
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
    public static class EditRouteResponseRouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteTransformOp value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteTransformOp.Append => "append",
                EditRouteResponseRouteRouteTransformOp.Delete => "delete",
                EditRouteResponseRouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => EditRouteResponseRouteRouteTransformOp.Append,
                "delete" => EditRouteResponseRouteRouteTransformOp.Delete,
                "set" => EditRouteResponseRouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}
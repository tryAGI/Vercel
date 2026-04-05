
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteRequestRouteRouteTransformOp
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
    public static class EditRouteRequestRouteRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteRequestRouteRouteTransformOp value)
        {
            return value switch
            {
                EditRouteRequestRouteRouteTransformOp.Append => "append",
                EditRouteRequestRouteRouteTransformOp.Delete => "delete",
                EditRouteRequestRouteRouteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteRequestRouteRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => EditRouteRequestRouteRouteTransformOp.Append,
                "delete" => EditRouteRequestRouteRouteTransformOp.Delete,
                "set" => EditRouteRequestRouteRouteTransformOp.Set,
                _ => null,
            };
        }
    }
}
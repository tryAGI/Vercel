
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum EditRouteResponseRouteRouteTransformVariant1Op
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
    public static class EditRouteResponseRouteRouteTransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteTransformVariant1Op value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteTransformVariant1Op.Append => "append",
                EditRouteResponseRouteRouteTransformVariant1Op.Delete => "delete",
                EditRouteResponseRouteRouteTransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteTransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => EditRouteResponseRouteRouteTransformVariant1Op.Append,
                "delete" => EditRouteResponseRouteRouteTransformVariant1Op.Delete,
                "set" => EditRouteResponseRouteRouteTransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}
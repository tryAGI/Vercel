
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteTransformVariant1Op
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
    public static class AddRouteResponseRouteRouteTransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteTransformVariant1Op value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteTransformVariant1Op.Append => "append",
                AddRouteResponseRouteRouteTransformVariant1Op.Delete => "delete",
                AddRouteResponseRouteRouteTransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteTransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => AddRouteResponseRouteRouteTransformVariant1Op.Append,
                "delete" => AddRouteResponseRouteRouteTransformVariant1Op.Delete,
                "set" => AddRouteResponseRouteRouteTransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}
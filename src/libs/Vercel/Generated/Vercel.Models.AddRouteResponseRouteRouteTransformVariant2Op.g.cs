
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteTransformVariant2Op
    {
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddRouteResponseRouteRouteTransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteTransformVariant2Op value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteTransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteTransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => AddRouteResponseRouteRouteTransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}
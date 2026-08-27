
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum EditRouteResponseRouteRouteTransformVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditRouteResponseRouteRouteTransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteTransformVariant2Op value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteTransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteTransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => EditRouteResponseRouteRouteTransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}
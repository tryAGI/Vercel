
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum EditRouteResponseRouteRouteTransformVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditRouteResponseRouteRouteTransformVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteTransformVariant2Type value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteTransformVariant2Type.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteTransformVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => EditRouteResponseRouteRouteTransformVariant2Type.RequestPath,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AddRouteResponseRouteRouteTransformVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddRouteResponseRouteRouteTransformVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteTransformVariant2Type value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteTransformVariant2Type.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteTransformVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => AddRouteResponseRouteRouteTransformVariant2Type.RequestPath,
                _ => null,
            };
        }
    }
}
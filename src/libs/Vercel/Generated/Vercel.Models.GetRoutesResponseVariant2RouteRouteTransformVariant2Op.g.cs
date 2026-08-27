
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteTransformVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant2RouteRouteTransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteTransformVariant2Op value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteTransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteTransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => GetRoutesResponseVariant2RouteRouteTransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}
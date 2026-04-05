
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteMissingItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddRouteResponseRouteRouteMissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteMissingItemVariant1Type value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteMissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteMissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AddRouteResponseRouteRouteMissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}
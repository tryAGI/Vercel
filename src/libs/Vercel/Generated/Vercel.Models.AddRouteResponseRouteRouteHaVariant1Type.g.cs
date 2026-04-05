
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteHaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddRouteResponseRouteRouteHaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteHaVariant1Type value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteHaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteHaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AddRouteResponseRouteRouteHaVariant1Type.Host,
                _ => null,
            };
        }
    }
}
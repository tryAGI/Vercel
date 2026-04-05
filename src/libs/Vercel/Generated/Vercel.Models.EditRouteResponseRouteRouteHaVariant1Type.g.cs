
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteHaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditRouteResponseRouteRouteHaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteHaVariant1Type value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteHaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteHaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => EditRouteResponseRouteRouteHaVariant1Type.Host,
                _ => null,
            };
        }
    }
}
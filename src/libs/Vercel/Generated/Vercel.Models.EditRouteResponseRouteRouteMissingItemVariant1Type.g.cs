
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteMissingItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditRouteResponseRouteRouteMissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteMissingItemVariant1Type value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteMissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteMissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => EditRouteResponseRouteRouteMissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}
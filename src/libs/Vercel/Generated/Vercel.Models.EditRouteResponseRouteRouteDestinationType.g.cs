
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditRouteResponseRouteRouteDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteDestinationType value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteDestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => EditRouteResponseRouteRouteDestinationType.Service,
                _ => null,
            };
        }
    }
}
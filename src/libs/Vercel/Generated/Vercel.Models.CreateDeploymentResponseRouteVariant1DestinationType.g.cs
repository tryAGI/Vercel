
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1DestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseRouteVariant1DestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1DestinationType value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1DestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1DestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => CreateDeploymentResponseRouteVariant1DestinationType.Service,
                _ => null,
            };
        }
    }
}
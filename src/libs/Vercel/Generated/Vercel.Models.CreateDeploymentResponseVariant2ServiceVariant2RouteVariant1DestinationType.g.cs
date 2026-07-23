
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1DestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1DestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1DestinationType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1DestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1DestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1DestinationType.Service,
                _ => null,
            };
        }
    }
}
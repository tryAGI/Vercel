
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant1DestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1RouteVariant1DestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant1DestinationType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant1DestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant1DestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => GetDeploymentResponseVariant1RouteVariant1DestinationType.Service,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource
    {
        /// <summary>
        /// 
        /// </summary>
        Configured,
        /// <summary>
        /// 
        /// </summary>
        Generated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource.Configured => "configured",
                GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource.Configured,
                "generated" => GetDeploymentResponseVariant1ServiceVariant1RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}
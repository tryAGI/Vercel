
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource
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
    public static class GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource.Configured => "configured",
                GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource.Configured,
                "generated" => GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}
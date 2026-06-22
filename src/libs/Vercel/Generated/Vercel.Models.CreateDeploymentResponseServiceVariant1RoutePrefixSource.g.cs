
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant1RoutePrefixSource
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
    public static class CreateDeploymentResponseServiceVariant1RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant1RoutePrefixSource value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant1RoutePrefixSource.Configured => "configured",
                CreateDeploymentResponseServiceVariant1RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant1RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => CreateDeploymentResponseServiceVariant1RoutePrefixSource.Configured,
                "generated" => CreateDeploymentResponseServiceVariant1RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}
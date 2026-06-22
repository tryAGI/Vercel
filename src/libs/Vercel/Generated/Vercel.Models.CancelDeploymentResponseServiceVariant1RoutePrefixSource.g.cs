
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1RoutePrefixSource
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
    public static class CancelDeploymentResponseServiceVariant1RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1RoutePrefixSource value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1RoutePrefixSource.Configured => "configured",
                CancelDeploymentResponseServiceVariant1RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => CancelDeploymentResponseServiceVariant1RoutePrefixSource.Configured,
                "generated" => CancelDeploymentResponseServiceVariant1RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}
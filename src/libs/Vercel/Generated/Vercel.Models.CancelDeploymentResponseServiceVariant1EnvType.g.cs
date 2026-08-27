
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant1EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1EnvType value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => CancelDeploymentResponseServiceVariant1EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}
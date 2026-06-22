
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant1EnvType
    {
        /// <summary>
        /// 
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant1EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant1EnvType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant1EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant1EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => GetDeploymentResponseVariant1ServiceVariant1EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}
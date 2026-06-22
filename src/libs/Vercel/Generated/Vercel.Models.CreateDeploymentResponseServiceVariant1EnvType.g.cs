
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant1EnvType
    {
        /// <summary>
        /// 
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant1EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant1EnvType value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant1EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant1EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => CreateDeploymentResponseServiceVariant1EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}
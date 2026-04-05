
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type that was used for the build.
    /// </summary>
    public enum GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType.Standard => "standard",
                GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => GetDeploymentResponseVariant1ConfigResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
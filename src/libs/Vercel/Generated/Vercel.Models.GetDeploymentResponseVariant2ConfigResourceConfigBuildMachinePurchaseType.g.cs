
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type that was used for the build.
    /// </summary>
    public enum GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
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
    public static class GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Basic => "basic",
                GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Standard => "standard",
                GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Basic,
                "enhanced" => GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => GetDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
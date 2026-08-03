
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
    /// </summary>
    public enum GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType
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
    public static class GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Basic => "basic",
                GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Standard => "standard",
                GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Basic,
                "enhanced" => GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => GetDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
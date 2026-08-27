
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType
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
    public static class CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Basic => "basic",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Standard => "standard",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Basic,
                "enhanced" => CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
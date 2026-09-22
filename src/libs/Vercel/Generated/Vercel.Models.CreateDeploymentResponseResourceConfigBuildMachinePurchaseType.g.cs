
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
    /// </summary>
    public enum CreateDeploymentResponseResourceConfigBuildMachinePurchaseType
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
    public static class CreateDeploymentResponseResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Basic => "basic",
                CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Standard => "standard",
                CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Basic,
                "enhanced" => CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => CreateDeploymentResponseResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
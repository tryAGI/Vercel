
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
    /// </summary>
    public enum CancelDeploymentResponseResourceConfigBuildMachinePurchaseType
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
    public static class CancelDeploymentResponseResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Basic => "basic",
                CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Standard => "standard",
                CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Basic,
                "enhanced" => CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => CancelDeploymentResponseResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
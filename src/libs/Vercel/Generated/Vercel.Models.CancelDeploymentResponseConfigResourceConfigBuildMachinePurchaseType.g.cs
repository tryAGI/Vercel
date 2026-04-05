
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type that was used for the build.
    /// </summary>
    public enum CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType
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
    public static class CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Standard => "standard",
                CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
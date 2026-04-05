
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type that was used for the build.
    /// </summary>
    public enum CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType
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
    public static class CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Standard => "standard",
                CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => CreateDeploymentResponseConfigResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
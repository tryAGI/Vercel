
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type that was used for the build.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType
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
    public static class CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Basic => "basic",
                CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Standard => "standard",
                CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Basic,
                "enhanced" => CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}
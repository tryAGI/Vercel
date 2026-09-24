
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
    /// </summary>
    public enum CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType
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
        None,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Basic => "basic",
                CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.None => "none",
                CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Basic,
                "enhanced" => CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "none" => CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.None,
                "standard" => CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}
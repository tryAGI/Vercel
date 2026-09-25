
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
    /// </summary>
    public enum CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType
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
    public static class CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Basic => "basic",
                CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.None => "none",
                CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Basic,
                "enhanced" => CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "none" => CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.None,
                "standard" => CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}
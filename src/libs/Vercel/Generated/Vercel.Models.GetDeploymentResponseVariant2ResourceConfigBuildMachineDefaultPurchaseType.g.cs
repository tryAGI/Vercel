
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
    /// </summary>
    public enum GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType
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
    public static class GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Basic => "basic",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.None => "none",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Basic,
                "enhanced" => GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "none" => GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.None,
                "standard" => GetDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}
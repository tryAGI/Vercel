
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The default plan type for the build machine — what the customer is *paying* for on their plan. For most customers, this is standard, but some customers have an entitlement for enhanced builds.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Basic => "basic",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Basic,
                "enhanced" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}
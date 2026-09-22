
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The default plan type for the build machine — what the customer is *paying* for on their plan. For most customers, this is standard, but some customers have an entitlement for enhanced builds.
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
                "standard" => CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}
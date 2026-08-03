
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The default plan type for the build machine — what the customer is *paying* for on their plan. For most customers, this is standard, but some customers have an entitlement for enhanced builds.
    /// </summary>
    public enum CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType
    {
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
    public static class CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
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
                "enhanced" => CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}
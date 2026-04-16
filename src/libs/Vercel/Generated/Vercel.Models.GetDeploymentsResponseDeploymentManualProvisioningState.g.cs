
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum GetDeploymentsResponseDeploymentManualProvisioningState
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentManualProvisioningState value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentManualProvisioningState.Complete => "COMPLETE",
                GetDeploymentsResponseDeploymentManualProvisioningState.Pending => "PENDING",
                GetDeploymentsResponseDeploymentManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => GetDeploymentsResponseDeploymentManualProvisioningState.Complete,
                "PENDING" => GetDeploymentsResponseDeploymentManualProvisioningState.Pending,
                "TIMEOUT" => GetDeploymentsResponseDeploymentManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}
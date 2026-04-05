
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum CancelDeploymentResponseManualProvisioningState
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
    public static class CancelDeploymentResponseManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseManualProvisioningState value)
        {
            return value switch
            {
                CancelDeploymentResponseManualProvisioningState.Complete => "COMPLETE",
                CancelDeploymentResponseManualProvisioningState.Pending => "PENDING",
                CancelDeploymentResponseManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => CancelDeploymentResponseManualProvisioningState.Complete,
                "PENDING" => CancelDeploymentResponseManualProvisioningState.Pending,
                "TIMEOUT" => CancelDeploymentResponseManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum CreateDeploymentResponseManualProvisioningState
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
    public static class CreateDeploymentResponseManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseManualProvisioningState value)
        {
            return value switch
            {
                CreateDeploymentResponseManualProvisioningState.Complete => "COMPLETE",
                CreateDeploymentResponseManualProvisioningState.Pending => "PENDING",
                CreateDeploymentResponseManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => CreateDeploymentResponseManualProvisioningState.Complete,
                "PENDING" => CreateDeploymentResponseManualProvisioningState.Pending,
                "TIMEOUT" => CreateDeploymentResponseManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}
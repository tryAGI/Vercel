
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum GetDeploymentResponseVariant3ManualProvisioningState
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
    public static class GetDeploymentResponseVariant3ManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3ManualProvisioningState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3ManualProvisioningState.Complete => "COMPLETE",
                GetDeploymentResponseVariant3ManualProvisioningState.Pending => "PENDING",
                GetDeploymentResponseVariant3ManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3ManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => GetDeploymentResponseVariant3ManualProvisioningState.Complete,
                "PENDING" => GetDeploymentResponseVariant3ManualProvisioningState.Pending,
                "TIMEOUT" => GetDeploymentResponseVariant3ManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}
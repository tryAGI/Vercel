
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum GetDeploymentResponseVariant2ManualProvisioningState
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
    public static class GetDeploymentResponseVariant2ManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ManualProvisioningState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ManualProvisioningState.Complete => "COMPLETE",
                GetDeploymentResponseVariant2ManualProvisioningState.Pending => "PENDING",
                GetDeploymentResponseVariant2ManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => GetDeploymentResponseVariant2ManualProvisioningState.Complete,
                "PENDING" => GetDeploymentResponseVariant2ManualProvisioningState.Pending,
                "TIMEOUT" => GetDeploymentResponseVariant2ManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}
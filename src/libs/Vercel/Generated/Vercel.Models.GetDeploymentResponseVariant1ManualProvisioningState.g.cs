
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum GetDeploymentResponseVariant1ManualProvisioningState
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
    public static class GetDeploymentResponseVariant1ManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ManualProvisioningState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ManualProvisioningState.Complete => "COMPLETE",
                GetDeploymentResponseVariant1ManualProvisioningState.Pending => "PENDING",
                GetDeploymentResponseVariant1ManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => GetDeploymentResponseVariant1ManualProvisioningState.Complete,
                "PENDING" => GetDeploymentResponseVariant1ManualProvisioningState.Pending,
                "TIMEOUT" => GetDeploymentResponseVariant1ManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}
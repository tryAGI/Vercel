
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Current provisioning state
    /// </summary>
    public enum CreateDeploymentResponseVariant2ManualProvisioningState
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
    public static class CreateDeploymentResponseVariant2ManualProvisioningStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ManualProvisioningState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ManualProvisioningState.Complete => "COMPLETE",
                CreateDeploymentResponseVariant2ManualProvisioningState.Pending => "PENDING",
                CreateDeploymentResponseVariant2ManualProvisioningState.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ManualProvisioningState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => CreateDeploymentResponseVariant2ManualProvisioningState.Complete,
                "PENDING" => CreateDeploymentResponseVariant2ManualProvisioningState.Pending,
                "TIMEOUT" => CreateDeploymentResponseVariant2ManualProvisioningState.Timeout,
                _ => null,
            };
        }
    }
}
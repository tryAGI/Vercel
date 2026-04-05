
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseIntegrationsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseIntegrationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseIntegrationsStatus value)
        {
            return value switch
            {
                CancelDeploymentResponseIntegrationsStatus.Error => "error",
                CancelDeploymentResponseIntegrationsStatus.Pending => "pending",
                CancelDeploymentResponseIntegrationsStatus.Ready => "ready",
                CancelDeploymentResponseIntegrationsStatus.Skipped => "skipped",
                CancelDeploymentResponseIntegrationsStatus.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseIntegrationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CancelDeploymentResponseIntegrationsStatus.Error,
                "pending" => CancelDeploymentResponseIntegrationsStatus.Pending,
                "ready" => CancelDeploymentResponseIntegrationsStatus.Ready,
                "skipped" => CancelDeploymentResponseIntegrationsStatus.Skipped,
                "timeout" => CancelDeploymentResponseIntegrationsStatus.Timeout,
                _ => null,
            };
        }
    }
}
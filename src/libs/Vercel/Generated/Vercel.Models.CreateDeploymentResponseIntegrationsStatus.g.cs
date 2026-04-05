
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseIntegrationsStatus
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
    public static class CreateDeploymentResponseIntegrationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseIntegrationsStatus value)
        {
            return value switch
            {
                CreateDeploymentResponseIntegrationsStatus.Error => "error",
                CreateDeploymentResponseIntegrationsStatus.Pending => "pending",
                CreateDeploymentResponseIntegrationsStatus.Ready => "ready",
                CreateDeploymentResponseIntegrationsStatus.Skipped => "skipped",
                CreateDeploymentResponseIntegrationsStatus.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseIntegrationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateDeploymentResponseIntegrationsStatus.Error,
                "pending" => CreateDeploymentResponseIntegrationsStatus.Pending,
                "ready" => CreateDeploymentResponseIntegrationsStatus.Ready,
                "skipped" => CreateDeploymentResponseIntegrationsStatus.Skipped,
                "timeout" => CreateDeploymentResponseIntegrationsStatus.Timeout,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2IntegrationsStatus
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
    public static class CreateDeploymentResponseVariant2IntegrationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2IntegrationsStatus value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2IntegrationsStatus.Error => "error",
                CreateDeploymentResponseVariant2IntegrationsStatus.Pending => "pending",
                CreateDeploymentResponseVariant2IntegrationsStatus.Ready => "ready",
                CreateDeploymentResponseVariant2IntegrationsStatus.Skipped => "skipped",
                CreateDeploymentResponseVariant2IntegrationsStatus.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2IntegrationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateDeploymentResponseVariant2IntegrationsStatus.Error,
                "pending" => CreateDeploymentResponseVariant2IntegrationsStatus.Pending,
                "ready" => CreateDeploymentResponseVariant2IntegrationsStatus.Ready,
                "skipped" => CreateDeploymentResponseVariant2IntegrationsStatus.Skipped,
                "timeout" => CreateDeploymentResponseVariant2IntegrationsStatus.Timeout,
                _ => null,
            };
        }
    }
}
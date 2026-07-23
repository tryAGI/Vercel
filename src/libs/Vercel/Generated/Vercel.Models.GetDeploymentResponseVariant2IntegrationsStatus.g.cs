
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2IntegrationsStatus
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
    public static class GetDeploymentResponseVariant2IntegrationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2IntegrationsStatus value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2IntegrationsStatus.Error => "error",
                GetDeploymentResponseVariant2IntegrationsStatus.Pending => "pending",
                GetDeploymentResponseVariant2IntegrationsStatus.Ready => "ready",
                GetDeploymentResponseVariant2IntegrationsStatus.Skipped => "skipped",
                GetDeploymentResponseVariant2IntegrationsStatus.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2IntegrationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentResponseVariant2IntegrationsStatus.Error,
                "pending" => GetDeploymentResponseVariant2IntegrationsStatus.Pending,
                "ready" => GetDeploymentResponseVariant2IntegrationsStatus.Ready,
                "skipped" => GetDeploymentResponseVariant2IntegrationsStatus.Skipped,
                "timeout" => GetDeploymentResponseVariant2IntegrationsStatus.Timeout,
                _ => null,
            };
        }
    }
}
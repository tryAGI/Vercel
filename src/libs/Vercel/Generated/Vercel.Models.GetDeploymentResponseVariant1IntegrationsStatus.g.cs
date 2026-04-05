
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1IntegrationsStatus
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
    public static class GetDeploymentResponseVariant1IntegrationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1IntegrationsStatus value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1IntegrationsStatus.Error => "error",
                GetDeploymentResponseVariant1IntegrationsStatus.Pending => "pending",
                GetDeploymentResponseVariant1IntegrationsStatus.Ready => "ready",
                GetDeploymentResponseVariant1IntegrationsStatus.Skipped => "skipped",
                GetDeploymentResponseVariant1IntegrationsStatus.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1IntegrationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDeploymentResponseVariant1IntegrationsStatus.Error,
                "pending" => GetDeploymentResponseVariant1IntegrationsStatus.Pending,
                "ready" => GetDeploymentResponseVariant1IntegrationsStatus.Ready,
                "skipped" => GetDeploymentResponseVariant1IntegrationsStatus.Skipped,
                "timeout" => GetDeploymentResponseVariant1IntegrationsStatus.Timeout,
                _ => null,
            };
        }
    }
}
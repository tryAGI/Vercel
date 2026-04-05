
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Building => "BUILDING",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Canceled => "CANCELED",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Error => "ERROR",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Initializing => "INITIALIZING",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Queued => "QUEUED",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Building,
                "CANCELED" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Canceled,
                "ERROR" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Error,
                "INITIALIZING" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Initializing,
                "QUEUED" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Queued,
                "READY" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}
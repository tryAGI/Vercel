
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
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
    public static class StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState value)
        {
            return value switch
            {
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Blocked => "BLOCKED",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Building => "BUILDING",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Canceled => "CANCELED",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Error => "ERROR",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Initializing => "INITIALIZING",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Queued => "QUEUED",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Blocked,
                "BUILDING" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Building,
                "CANCELED" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Canceled,
                "ERROR" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Error,
                "INITIALIZING" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Initializing,
                "QUEUED" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Queued,
                "READY" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}